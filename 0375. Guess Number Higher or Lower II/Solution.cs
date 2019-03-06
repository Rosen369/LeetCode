public class Solution {
    public int GetMoneyAmount (int n) {
        var dp = new int[n + 1, n + 1];
        return Recursive (dp, 1, n);
    }

    public int Recursive (int[, ] dp, int left, int right) {
        if (left >= right) {
            return 0;
        }
        if (dp[left, right] != 0) {
            return dp[left, right];
        }
        var res = int.MaxValue;
        for (int i = left; i <= right; i++) {
            var next = i + Math.Max (Recursive (dp, left, i - 1), Recursive (dp, i + 1, right));
            res = Math.Min (res, next);
        }
        dp[left, right] = res;
        return res;
    }
}