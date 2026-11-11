public class Solution {
    public record struct Point(int x,int y);
    static readonly int[] dx = {-1,1,0,0};
    static readonly int[] dy = {0,0,-1,1};
    private HashSet<(int,int)> pacific = new ();
    private HashSet<(int,int)> atlantic = new ();

    public List<List<int>> PacificAtlantic(int[][] heights) {
        var ans = new List<List<int>>();
        if(heights.Length == 0) return ans;
        void Dfs(int i, int j, int prev, HashSet<(int,int)> visited) {
            if(
                visited.Contains((i,j)) ||
                i < 0 || i == heights.Length || 
                j < 0 || j == heights[i].Length || heights[i][j] < prev) {
                    return;
            }
            visited.Add((i,j));
            for(int k = 0; k < 4; k++) {
                int px = dx[k] + i;
                int py = dy[k] + j;
                Dfs(px,py,heights[i][j],visited);
            }
        }
        for(int i = 0; i < heights[0].Length; i++) {
            Dfs(0,i,heights[0][i],pacific);
            Dfs(heights.Length - 1,i,heights[heights.Length-1][i],atlantic);
        }
        for(int i = 0; i < heights.Length; i++) {
            Dfs(i,0,heights[i][0],pacific);
            Dfs(i,heights[i].Length - 1,heights[i][heights[i].Length-1],atlantic);
        }
        for(int i = 0; i < heights.Length; i++) {
            for(int j = 0; j < heights[i].Length; j++) {
                if(atlantic.Contains((i,j)) && pacific.Contains((i,j))) {
                    ans.Add(new int[]{i,j}.ToList());
                }
            }
        }
        return ans;
    }
}
