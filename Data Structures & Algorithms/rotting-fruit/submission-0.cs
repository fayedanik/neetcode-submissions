public class Solution {
    public record struct Point(int x,int y,int t);
    static readonly int[] dx = {0,0,-1,1};
    static readonly int[] dy = {-1,1,0,0};
    public int OrangesRotting(int[][] grid) {
        var q = new Queue<Point>();
        int fresh = 0;
        for(int i = 0; i < grid.Length; i++) {
            for(int j = 0; j < grid[i].Length; j++) {
                if(grid[i][j] == 2) {
                    q.Enqueue(new Point(i,j,0));
                }
                if(grid[i][j] == 1) {
                    fresh++;
                }
            }
        }
        int ans = -1;
        while(q.Count > 0) {
            var p = q.Peek();
            q.Dequeue();
            for(int k = 0; k < 4; k++) {
                int px = dx[k] + p.x;
                int py = dy[k] + p.y;
                if(
                    px > -1 && px < grid.Length && 
                    py > -1 && py < grid[px].Length && 
                    grid[px][py] == 1) {
                        q.Enqueue(new Point(px,py,p.t+1));
                        ans = Math.Max(ans, p.t+1);
                        grid[px][py] = 2;
                        fresh--;
                    }
            }
        }
        return fresh == 0 ? ans : -1;
    }
}
