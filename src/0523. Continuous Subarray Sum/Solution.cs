public class Solution {
    public bool CheckSubarraySum (int[] nums, int k) {
        for (int i = 0; i < nums.Length - 1; i++) {
            if (nums[i] == 0 && nums[i + 1] == 0) {
                return true;
            }
        }
        if (k == 0) {
            return false;
        }
        var dp = new int[nums.Length, nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            dp[i, i] = nums[i];
            for (int j = i + 1; j < nums.Length; j++) {
                dp[i, j] = dp[i, j - 1] + nums[j];
                if (dp[i, j] % k == 0) {
                    return true;
                }
            }
        }
        return false;
    }
}