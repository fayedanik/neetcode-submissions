public class Solution {
    public int Trap(int[] height) {
        if(height == null || height.Length == 0 ) {
            return 0;
        }
        int water = 0;
        int l = 0, r = height.Length - 1;
        int max_left = height[l], max_right = height[r];
        while(l < r) {
            if(max_left < max_right) {
                l++;
                max_left = Math.Max(max_left,height[l]);
                water += max_left - height[l];
                
                
            } else {
                r--;
                max_right = Math.Max(max_right,height[r]);
                water += max_right - height[r];
                
                
            }
        }
        
        return water;
    }
}
