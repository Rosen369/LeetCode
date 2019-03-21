public class Solution {
    public int NthUglyNumber (int n) {
        if (n == 1) {
            return 1;
        }
        var dp = new int[n];
        dp[0] = 1;
        var t2 = 0;
        var t3 = 0;
        var t5 = 0;
        for (int i = 1; i < n; i++) {
            dp[i] = Math.Min (dp[t2] * 2, (Math.Min (dp[t3] * 3, dp[t5] * 5)));
            if (dp[i] == dp[t2] * 2) t2++;
            if (dp[i] == dp[t3] * 3) t3++;
            if (dp[i] == dp[t5] * 5) t5++;
        }
        return dp[n - 1];
    }
}