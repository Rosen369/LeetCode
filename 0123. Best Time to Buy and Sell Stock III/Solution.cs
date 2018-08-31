public class Solution {
    public int MaxProfit (int[] prices) {
        if (prices.Length == 0) return 0;
        var dp = new int[3, prices.Length];
        for (int k = 1; k <= 2; k++) {
            for (int i = 1; i < prices.Length; i++) {
                int min = prices[0];
                for (int j = 1; j <= i; j++) {
                    min = Math.Min (min, prices[j] - dp[k - 1, j - 1]);
                }
                dp[k, i] = Math.Max (dp[k, i - 1], prices[i] - min);
            }
        }
        return dp[2, prices.Length - 1];
    }
}