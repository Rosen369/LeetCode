public class Solution {
    public int MaxProfit (int k, int[] prices) {
        if (prices.Length == 0) return 0;
        if (k >= prices.Length / 2) {
            var profit = 0;
            for (int i = 1; i < prices.Length; i++) {
                if (prices[i] > prices[i - 1])
                    profit += prices[i] - prices[i - 1];
            }
            return profit;
        }
        var dp = new int[k + 1];
        var min = new int[k + 1];
        Array.Fill (min, prices[0]);
        for (int i = 1; i < prices.Length; i++) {
            for (int t = 1; t <= k; t++) {
                min[t] = Math.Min (min[t], prices[i] - dp[t - 1]);
                dp[t] = Math.Max (dp[t], prices[i] - min[t]);
            }
        }
        return dp[k];
    }
}