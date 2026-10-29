public class Solution {
    static int[] nx = new int[] {1,0,-1,0};
    static int[] ny = new int[] {0,1,0,-1};
    public void Dfs(int i, int j, bool[][] visited,char[][] grid) {
        if(i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length) return;
        if(visited[i][j] == true || grid[i][j] == '0') return;
        visited[i][j] = true;
        for(int k = 0; k < 4; k++) {
            int dx = i + nx[k];
            int dy = j + ny[k];
            Dfs(dx,dy,visited,grid);
        }
    }
    public int NumIslands(char[][] grid) {
        var n = grid.Length;
        if(n == 0) return 0;
        bool[][] visited = new bool[n][]; 
        int ans = 0;
        for (int i = 0; i < n; i++)
        {
            visited[i] = new bool[grid[i].Length];
        }
        for(int i = 0; i < n; i++) {
            for(int j = 0; j < grid[i].Length; j++) {
                if(grid[i][j] == '1' && !visited[i][j]) {
                    Dfs(i,j,visited,grid);
                    ans++;
                }
            }
        }
        
        return ans;
    }
}