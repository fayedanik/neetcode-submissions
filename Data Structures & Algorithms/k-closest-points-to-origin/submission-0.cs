public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var pq = new PriorityQueue<int,int>();
        for(int i = 0; i < points.Length; i++) {
            int x = points[i][0];
            int y = points[i][1];
            int distance = x*x + y*y;
            pq.Enqueue(i,distance);
        }
        int cnt = 0;
        int[][] ans = new int[k][];
        while(cnt < k && pq.Count > 0) {
            int pos = pq.Dequeue();
            ans[cnt] = new int[]{points[pos][0],points[pos][1]};
            cnt++;
        }
        return ans;
    }
}
