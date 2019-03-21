public class Solution {
    public int LongestIncreasingPath (int[, ] matrix) {
        var m = matrix.GetLength (0);
        var n = matrix.GetLength (1);
        var max = 0;
        var dp = new int[m, n];
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                max = Math.Max (max, Recursive (matrix, i, j, m, n, dp));
            }
        }
        return max;
    }

    public int Recursive (int[, ] matrix, int i, int j, int m, int n, int[, ] dp) {
        if (dp[i, j] != 0) {
            return dp[i, j];
        }
        var max = 1;
        if (i - 1 >= 0 && matrix[i - 1, j] > matrix[i, j]) {
            max = Math.Max (max, 1 + Recursive (matrix, i - 1, j, m, n, dp));
        }
        if (i + 1 < m && matrix[i + 1, j] > matrix[i, j]) {
            max = Math.Max (max, 1 + Recursive (matrix, i + 1, j, m, n, dp));
        }
        if (j - 1 >= 0 && matrix[i, j - 1] > matrix[i, j]) {
            max = Math.Max (max, 1 + Recursive (matrix, i, j - 1, m, n, dp));
        }
        if (j + 1 < n && matrix[i, j + 1] > matrix[i, j]) {
            max = Math.Max (max, 1 + Recursive (matrix, i, j + 1, m, n, dp));
        }
        dp[i, j] = max;
        return max;
    }
}