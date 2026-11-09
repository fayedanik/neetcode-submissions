public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var res = new List<List<int>>();
        for(int k = 0; k < nums.Length; k++) {
            int i = k+1, j = nums.Length - 1,target = -nums[k];
            while(i < j) {
                if(nums[i]+nums[j]==target) {
                    res.Add(new List<int> {nums[i],nums[j],nums[k]});
                    i++;
                    j--;
                } else {
                    if(nums[i] + nums[j] > target) i++;
                    else j--;
                }
            }
        }
        return res;
    }
}
