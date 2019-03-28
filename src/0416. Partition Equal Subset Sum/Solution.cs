public class Solution {
    public bool CanPartition (int[] nums) {
        var sum = 0;
        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i];
        }
        if (sum % 2 == 1) {
            return false;
        }
        var target = sum / 2;
        var dp = new bool[target + 1];
        dp[0] = true;
        for (int i = 0; i < nums.Length; i++) {
            var n = nums[i];
            for (int j = target; j >= n; j--) {
                dp[j] = dp[j] || dp[j - n];
            }
        }
        return dp[target];
    }
}