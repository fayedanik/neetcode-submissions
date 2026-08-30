public class Solution {
    public bool CanJump(int[] nums) {
        int mx_so_far = 0;
        for(int i = 0; i < nums.Length - 1; i++) {
            mx_so_far = Math.Max(mx_so_far,nums[i]+i);
            if(nums[i] == 0 && mx_so_far <= i) {
                return false;
            }
        }
        return true;
    }
}
