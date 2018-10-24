public class Solution {
    public int CalculateMinimumHP (int[][] dungeon) {
        var row = dungeon.Length;
        var col = dungeon[0].Length;
        var dp = new int[row + 1, col + 1];
        for (int i = 0; i < row - 1; i++) {
            dp[i, col] = int.MaxValue;
        }
        for (int j = 0; j < col - 1; j++) {
            dp[row, j] = int.MaxValue;
        }
        dp[row, col - 1] = 1;
        dp[row - 1, col] = 1;
        for (int i = row - 1; i >= 0; i--) {
            for (int j = col - 1; j >= 0; j--) {
                var need = Math.Min (dp[i + 1, j], dp[i, j + 1]) - dungeon[i][j];
                if (need <= 0) {
                    dp[i, j] = 1;
                } else {
                    dp[i, j] = need;
                }
            }
        }
        return dp[0, 0];
    }
}