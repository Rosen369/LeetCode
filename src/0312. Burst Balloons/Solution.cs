public class Solution {
    public int MaxCoins (int[] nums) {
        var n = nums.Length;
        var dp = new int[n, n];
        return this.DFS (dp, 0, n - 1, nums, 1, 1);
    }

    private int DFS (int[, ] dp, int i, int j, int[] nums, int left, int right) {
        if (i > j) {
            return 0;
        }
        if (dp[i, j] > 0) {
            return dp[i, j];
        }
        var max = 0;
        for (var n = i; n <= j; n++) {
            var p1 = this.DFS (dp, i, n - 1, nums, left, nums[n]);
            var p2 = left * nums[n] * right;
            var p3 = this.DFS (dp, n + 1, j, nums, nums[n], right);

            max = Math.Max (max, p1 + p2 + p3);
        }

        dp[i, j] = max;
        return max;
    }
}