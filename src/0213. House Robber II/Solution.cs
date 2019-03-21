public class Solution {
    public int Rob (int[] nums) {
        if (nums.Length == 0) {
            return 0;
        }
        if (nums.Length == 1) {
            return nums[0];
        }
        if (nums.Length == 2) {
            return Math.Max (nums[0], nums[1]);
        }
        var robFromOne = RobLeftToRight (nums, 0, nums.Length - 2);
        var robFromTwo = RobLeftToRight (nums, 1, nums.Length - 1);
        return Math.Max (robFromOne, robFromTwo);
    }

    public int RobLeftToRight (int[] nums, int left, int right) {
        var dp = new int[nums.Length - 1];
        dp[0] = nums[left];
        dp[1] = Math.Max (nums[left], nums[left + 1]);
        for (int i = 2; i < nums.Length - 1; i++) {
            dp[i] = Math.Max (dp[i - 1], dp[i - 2] + nums[left + 2]);
            left++;
        }
        return dp[nums.Length - 2];
    }
}