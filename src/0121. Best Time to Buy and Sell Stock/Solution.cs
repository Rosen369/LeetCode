public class Solution {
    public int MaxProfit (int[] prices) {
        if (prices.Length == 0) {
            return 0;
        }
        var profit = 0;
        var low = prices[0];
        for (int i = 1; i < prices.Length; i++) {
            if (prices[i] < low) {
                low = prices[i];
            } else {
                profit = Math.Max (profit, prices[i] - low);
            }
        }
        return profit;
    }
}