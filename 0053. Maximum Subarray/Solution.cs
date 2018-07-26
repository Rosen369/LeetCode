public class Solution {
    public int MaxSubArray (int[] nums) {
        var dp = new int[nums.Length];
        dp[0] = nums[0];
        var max = dp[0];
        for (int i = 1; i < nums.Length; i++) {
            if (dp[i - 1] > 0) {
                dp[i] = dp[i - 1] + nums[i];
            } else {
                dp[i] = nums[i];
            }
            max = Math.Max (max, dp[i]);
        }
        return max;
    }
}