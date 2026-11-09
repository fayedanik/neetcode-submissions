public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Array.Sort(nums);
        int i = 0, j = nums.Length - 1;
        while( i < j ) {
            if( nums[i] + nums[j] == target ) return new int[] {i,j};
            else if( nums[i] + nums[j] > target ) {
                if( nums[i] < nums[j] ) {
                    j--;
                } else {
                    i++;
                }
            } else {
                if( nums[i] > nums[j] ) {
                    j--;
                } else {
                    i++;
                }
            }
        }

        return new int[] {-1,-1};
    }

    
}
