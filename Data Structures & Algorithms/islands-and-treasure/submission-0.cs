public class Solution {
    public record struct Point(int I,int J);
    static readonly int[] nx = {0,0,-1,1};
    static readonly int[] ny = {1,-1,0,0};

    public void islandsAndTreasure(int[][] grid) {
        int[][] dist = new int[grid.Length][];
        var q = new Queue<Point>();
        for(int i = 0; i < grid.Length; i++) {
            for(int j = 0; j < grid[i].Length; j++) {
                if(grid[i][j] == 0) {
                    q.Enqueue(new Point(i,j));
                }
            }
        }
        while(q.Count > 0) {
            var point = q.Peek();
            q.Dequeue();
            for(int k = 0; k < 4; k++) {
                var (px,py) = (point.I + nx[k],point.J + ny[k]);
                if(
                    px > -1 && px < grid.Length && 
                    py > -1 && py < grid[px].Length && 
                    grid[px][py] != -1 && grid[px][py] == int.MaxValue) {
                    grid[px][py] = grid[point.I][point.J] + 1;
                    q.Enqueue(new Point(px,py));
                }
            }
        }
    }
}
