public class Solution {
    public int UniquePathsWithObstacles (int[, ] obstacleGrid) {
        var m = obstacleGrid.GetLength (0);
        var n = obstacleGrid.GetLength (1);
        var dp = new int[m, n];
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (obstacleGrid[i, j] == 1) {
                    dp[i, j] = 0;
                } else if (i == 0 && j == 0) {
                    dp[i, j] = 1;
                } else if (i == 0) {
                    dp[i, j] = dp[i, j - 1];

                } else if (j == 0) {
                    dp[i, j] = dp[i - 1, j];

                } else {
                    dp[i, j] = dp[i, j - 1] + dp[i - 1, j];
                }
            }
        }
        return dp[m - 1, n - 1];
    }
}