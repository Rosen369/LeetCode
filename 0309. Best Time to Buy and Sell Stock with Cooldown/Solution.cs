public class Solution {
    public int MaxProfit (int[] prices) {
        if (prices.Length == 0) {
            return 0;
        }
        int b0 = -prices[0], b1 = b0;
        int s0 = 0, s1 = 0, s2 = 0;
        for (int i = 1; i < prices.Length; i++) {
            b0 = Math.Max (b1, s2 - prices[i]);
            s0 = Math.Max (s1, b1 + prices[i]);
            b1 = b0;
            s2 = s1;
            s1 = s0;
        }
        return s0;
    }
}