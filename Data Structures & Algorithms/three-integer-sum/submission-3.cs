public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var res = new List<List<int>>();
        for(int k = 0; k < nums.Length; k++) {
            int i = k+1, j = nums.Length - 1,target = -nums[k];
            if(k > 0 && nums[k] == nums[k-1]) continue;
            while(i < j) {
                if(nums[i]+nums[j]==target) {
                    res.Add(new List<int> {nums[i],nums[j],nums[k]});
                    i++;
                    j--;
                    while(i < j && nums[i] == nums[i-1]) i++;
                } else {
                    if(nums[i] + nums[j] < target) i++;
                    else j--;
                }
            }
        }
        return res;
    }
}
