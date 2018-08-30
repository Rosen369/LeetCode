public class Solution {
    public int MaxProfit (int[] prices) {
        if (prices.Length == 0) {
            return 0;
        }
        var profit = 0;
        for (int i = 0; i < prices.Length - 1; i++) {
            if (prices[i] < prices[i + 1]) {
                profit += prices[i + 1] - prices[i];
            }
        }
        return profit;
    }
}