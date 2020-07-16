public class Solution {
    public int RemoveBoxes (int[] boxes) {
        var n = boxes.Length;
        var dp = new int[n, n, n];
        return this.Sub (boxes, dp, 0, n - 1, 0);
    }

    private int Sub (int[] boxes, int[, , ] dp, int i, int j, int k) {
        if (i > j) {
            return 0;
        }
        if (dp[i, j, k] > 0) {
            return dp[i, j, k];
        }

        for (; i + 1 <= j && boxes[i + 1] == boxes[i]; i++, k++);

        var res = (k + 1) * (k + 1) + this.Sub (boxes, dp, i + 1, j, 0);

        for (int m = i + 1; m <= j; m++) {
            if (boxes[i] == boxes[m]) {
                var sep = this.Sub (boxes, dp, i + 1, m - 1, 0) + this.Sub (boxes, dp, m, j, k + 1);
                res = Math.Max (res, sep);
            }
        }

        dp[i, j, k] = res;
        return res;
    }
}