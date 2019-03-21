public class Solution {
    public int MaxCoins (int[] nums) {
        var len = nums.Length;
        var expand = new int[len + 2];
        expand[0] = 1;
        expand[len + 1] = 1;
        for (int i = 1; i <= len; i++) {
            expand[i] = nums[i - 1];
        }
        var memo = new int[len + 2, len + 2];
        return Backtracking (expand, memo, 0, len + 1);
    }

    public int Backtracking (int[] nums, int[, ] memo, int left, int right) {
        if (left + 1 == right) {
            return 0;
        }
        if (memo[left, right] > 0) {
            return memo[left, right];
        }
        var max = 0;
        for (int i = left + 1; i < right; i++) {
            var lMax = Backtracking (nums, memo, left, i);
            var rMax = Backtracking (nums, memo, i, right);
            var curr = nums[left] * nums[i] * nums[right] + lMax + rMax;
            max = Math.Max (max, curr);
        }
        memo[left, right] = max;
        return max;
    }
}