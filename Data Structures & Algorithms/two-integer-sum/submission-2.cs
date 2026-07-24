public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int,int>();
        for( int i = 0; i < nums.Length; i++ ) {
            int j = target - nums[i];
            if(dict.ContainsKey(j)) {
                return new int[] {dict[j],i};
            }
            dict.Add(nums[i],i);
        }
        return new int[] {-1,-1};
    }
}
