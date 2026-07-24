public class Solution {
    public int Trap(int[] height) {
        int ans = 0;
        for(int i = 0; i < height.Length; i++){
            int leftMax = height[i],rightMax = height[i];
            for(int j = 0; j < i; j++) {
                leftMax = Math.Max(leftMax,height[j]);
            }
            for(int j = i + 1; j < height.Length; j++) {
                rightMax = Math.Max(rightMax,height[j]);
            }

            ans += Math.Max(0,Math.Min(leftMax,rightMax) - height[i]);
        }
        return ans;
    }
}
