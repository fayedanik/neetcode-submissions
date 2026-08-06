public class Solution {
    public int MaxSubArray(int[] nums) {
        int max_ans = int.MinValue;
        for(int i = 0; i < nums.Length; i++) {
            max_ans = Math.Max(max_ans,nums[i]);
        }
        int sumtillNow = 0;
        for(int i = 0; i< nums.Length; i++) {
            sumtillNow += nums[i];
            max_ans = Math.Max(max_ans,sumtillNow);
            if(sumtillNow < 0) sumtillNow = 0;
        }
        return max_ans;
    }
}
