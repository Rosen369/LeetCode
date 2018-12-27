public class Solution {
    public int NumSquares (int n) {
        if (n <= 0) {
            return 0;
        }
        var dp = new int[n + 1];
        for (int i = 1; i <= n; i++) {
            for (int j = 1; j * j <= i; j++) {
                dp[i] = Math.Min (dp[i], dp[i - j * j] + 1);
            }
        }
        return dp[n];
    }
}