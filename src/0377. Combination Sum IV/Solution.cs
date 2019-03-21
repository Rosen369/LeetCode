public class Solution {
    public int CombinationSum4 (int[] nums, int target) {
        var dp = new int[target + 1];
        Array.Fill (dp, -1);
        dp[0] = 1;
        return Recursive (nums, target, dp);
    }

    public int Recursive (int[] nums, int target, int[] dp) {
        if (dp[target] != -1) {
            return dp[target];
        }
        var res = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (target >= nums[i]) {
                res += Recursive (nums, target - nums[i], dp);
            }
        }
        dp[target] = res;
        return res;
    }
}