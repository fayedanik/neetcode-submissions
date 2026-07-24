public class Solution {
    public int MaxArea(int[] heights) {
        int ans = 0;
        int L = 0, R = heights.Length - 1;
        while(L < R) {
            if(heights[L] < heights[R]) {
                ans = Math.Max(ans,heights[L] * (R-L));
                L++;
            } else {
                ans = Math.Max(ans,heights[R] * (R-L));
                R--;
            }
        }
        return ans;
    }
}
