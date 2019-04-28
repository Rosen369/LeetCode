public class Solution {
    public int[][] ColorBorder (int[][] grid, int r0, int c0, int color) {
        var res = new int[grid.Length][];
        for (int i = 0; i < grid.Length; i++) {
            res[i] = new int[grid[i].Length];
            for (int j = 0; j < grid[i].Length; j++) {
                res[i][j] = -1;
            }
        }
        this.DFS (grid, res, r0, c0, color, grid[r0][c0]);
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (res[i][j] == -1) {
                    res[i][j] = grid[i][j];
                }
            }
        }
        return res;
    }

    private void DFS (int[][] grid, int[][] res, int row, int col, int color, int c) {
        if (row < 0 || row >= grid.Length) return;
        if (col < 0 || col >= grid[0].Length) return;
        if (res[row][col] != -1) return;
        if (grid[row][col] != c) return;
        var border = false;
        if (row == 0 || row == grid.Length - 1) border = true;
        if (col == 0 || col == grid[0].Length - 1) border = true;
        var directions = new int[, ] { {-1, 0 }, { 1, 0 }, { 0, 1 }, { 0, -1 } };
        if (!border) {
            for (int i = 0; i < 4; i++) {
                if (grid[row + directions[i, 0]][col + directions[i, 1]] != grid[row][col]) {
                    border = true;
                    break;
                }
            }
        }
        if (border) {
            res[row][col] = color;
        } else {
            res[row][col] = grid[row][col];
        }
        for (int i = 0; i < 4; i++) {
            this.DFS (grid, res, row + directions[i, 0], col + directions[i, 1], color, c);
        }
    }
}