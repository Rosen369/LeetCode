public class Solution {
    public int IslandPerimeter (int[][] grid) {
        var count = 0;
        var row = grid.Length;
        var col = grid[0].Length;
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                if (grid[i][j] == 0) {
                    continue;
                }
                if (i == 0 || grid[i - 1][j] == 0) {
                    count++;
                }
                if (j == 0 || grid[i][j - 1] == 0) {
                    count++;
                }
                if (i == row - 1 || grid[i + 1][j] == 0) {
                    count++;
                }
                if (j == col - 1 || grid[i][j + 1] == 0) {
                    count++;
                }
            }
        }
        return count;
    }
}