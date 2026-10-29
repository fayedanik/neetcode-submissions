public class Solution {
    static int[] nx = new int[] {1,0,-1,0};
    static int[] ny = new int[] {0,1,0,-1};
    public void Dfs(int i,int j,char[][] grid) {
        if(i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length) return;
        if(grid[i][j] == '0') return;
        grid[i][j] = '0';
        for(int k = 0; k < 4; k++) {
            int dx = i + nx[k];
            int dy = j + ny[k];
            Dfs(dx,dy,grid);
        }
    }
    public int NumIslands(char[][] grid) {
        if(grid == null || grid.Length == 0) return 0;
        int ans = 0;
        for(int i = 0; i < grid.Length; i++) {
            for(int j = 0; j < grid[i].Length; j++) {
                if(grid[i][j] == '1') {
                    Dfs(i,j,grid);
                    ans++;
                }
            }
        }
        
        return ans;
    }
}