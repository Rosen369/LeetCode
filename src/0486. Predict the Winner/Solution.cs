public class Solution {
    public bool PredictTheWinner (int[] nums) {
        var dp = new int[nums.Length, nums.Length];
        for (var s = nums.Length - 1; s >= 0; s--) {
            dp[s, s] = nums[s];
            for (var e = s + 1; e < nums.Length; e++) {
                var a = nums[s] - dp[s + 1, e];
                var b = nums[e] - dp[s, e - 1];
                dp[s, e] = Math.Max (a, b);
            }
        }
        return dp[0, nums.Length - 1] >= 0;
    }
}