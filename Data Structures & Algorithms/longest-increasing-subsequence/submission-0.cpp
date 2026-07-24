class Solution {
public:
    int lengthOfLIS(vector<int>& nums) {
        int dp[nums.size()];
        for(int i = nums.size() - 1; i >= 0; i--) {
            int _max = 0;
            for( int j = i+1; j < nums.size(); j++ ) {
                if( nums[i] < nums[j] ) {
                    _max = max(_max,dp[j]);
                }
                
            }
            dp[i] = _max + 1;
        }
        int ans = 0;
        for( int i = 0; i < nums.size(); i++ ) {
            ans = max(ans,dp[i]);
        }
        return ans;
    }
};
