#define Lim 1005

int dp[Lim][Lim];

class Solution {

public:
    int F(int i,int j,string text1,string text2) {
        if( i >= text1.size() || j >= text2.size() ) return 0;
        int &res = dp[i][j];
        if( ~res ) return res;
        res = ((text1[i] == text2[j]) ? 1 : 0) + F(i+1,j+1,text1,text2);
        res = max(res,F(i+1,j,text1,text2));
        res = max(res,F(i,j+1,text1,text2));
        return res;
    }
public:
    int longestCommonSubsequence(string text1, string text2) {
        memset(dp,-1,sizeof dp);
        return F(0,0,text1,text2);
    }
};
