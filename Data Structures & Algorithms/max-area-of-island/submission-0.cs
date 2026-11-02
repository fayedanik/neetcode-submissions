public class Solution {
    static int[] dx = {0,0,1,-1};
    static int[] dy = {1,-1,0,0};

    private int FindMaxArea(int i, int j, int[][] grid) {
        if(i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length) return 0;
        if(grid[i][j] == 0) return 0;
        int area = (grid[i][j] == 1) ? 1 : 0;
        grid[i][j] = 0;
        for(int k = 0; k < 4; k++) {
            area += FindMaxArea(i+dx[k],j+dy[k],grid);
        }
        return area;
    }

    public int MaxAreaOfIsland(int[][] grid) {
        int ans = 0;
        for(int i = 0; i < grid.Length; i++) {
            for(int j = 0; j < grid[i].Length; j++) {
                ans = Math.Max(ans,FindMaxArea(i,j,grid));
            }
        }
        return ans;
    }
}
