public class Solution {
    public bool IsInterleave (string s1, string s2, string s3) {
        if (s1.Length + s2.Length != s3.Length) {
            return false;
        }
        var dp = new bool[s1.Length + 1, s2.Length + 1];
        for (int i = 0; i <= s1.Length; i++) {
            for (int j = 0; j <= s2.Length; j++) {
                if (i == 0 && j == 0) {
                    dp[i, j] = true;
                } else if (i == 0) {
                    if (dp[i, j - 1] && s2[j - 1] == s3[j - 1]) {
                        dp[i, j] = true;
                    } else {
                        dp[i, j] = false;
                    }
                } else if (j == 0) {
                    if (dp[i - 1, j] && s1[i - 1] == s3[i - 1]) {
                        dp[i, j] = true;
                    } else {
                        dp[i, j] = false;
                    }
                } else {
                    if (dp[i - 1, j] && s1[i - 1] == s3[i + j - 1]) {
                        dp[i, j] = true;
                    } else if (dp[i, j - 1] && s2[j - 1] == s3[i + j - 1]) {
                        dp[i, j] = true;
                    } else {
                        dp[i, j] = false;
                    }
                }
            }
        }
        return dp[s1.Length, s2.Length];
    }
}