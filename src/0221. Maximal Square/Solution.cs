public class Solution {
    public int MaximalSquare (char[, ] matrix) {
        var row = matrix.GetLength (0);
        var col = matrix.GetLength (1);
        var dp = new int[row, col];
        var res = 0;
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                if (i == 0 || j == 0) {
                    if (matrix[i, j] == '1') {
                        dp[i, j] = 1;
                    } else {
                        dp[i, j] = 0;
                    }
                } else if (matrix[i, j] == '0') {
                    dp[i, j] = 0;
                } else if (dp[i - 1, j] == 0 || dp[i, j - 1] == 0 || dp[i - 1, j - 1] == 0) {
                    dp[i, j] = 1;
                    continue;
                } else {
                    var min = Math.Min (dp[i - 1, j], dp[i, j - 1]);
                    min = Math.Min (min, dp[i - 1, j - 1]);
                    var pow = (int) Math.Sqrt (min);
                    dp[i, j] = (int) Math.Pow (pow + 1, 2);
                }
                res = Math.Max (res, dp[i, j]);
            }
        }
        return res;
    }
}