public class Solution {
    public int NumDecodings (string s) {
        if (string.IsNullOrEmpty (s) || s[0] == '0') {
            return 0;
        }
        var dp = new int[s.Length + 1];
        dp[0] = 1;
        dp[1] = s[0] != '0' ? 1 : 0;
        for (int i = 2; i <= s.Length; i++) {
            var first = Convert.ToInt32 (s.Substring (i - 1, 1));
            var second = Convert.ToInt32 (s.Substring (i - 2, 2));
            if (first >= 1 && first <= 9) {
                dp[i] += dp[i - 1];
            }
            if (second >= 10 && second <= 26) {
                dp[i] += dp[i - 2];
            }
        }
        return dp[s.Length];
    }
}