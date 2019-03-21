public class Solution {
    public int IntegerBreak (int n) {
        if (n == 2) return 1;
        if (n == 3) return 2;
        int product = 1;
        while (n > 4) {
            product *= 3;
            n -= 3;
        }
        product *= n;
        return product;
    }

    public int IntegerBreakDP (int n) {
        int[] dp = new int[n + 1];
        dp[1] = 1;
        for (int i = 2; i <= n; i++) {
            var max = 1;
            for (int j = 1; j < i; j++) {
                var factor1 = Math.Max (j, dp[j]);
                var factor2 = Math.Max (i - j, dp[i - j]);
                max = Math.Max (max, factor1 * factor2);
            }
            dp[i] = max;
        }
        return dp[n];
    }
}