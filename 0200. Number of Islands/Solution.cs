public class Solution {
    public int NumIslands (char[, ] grid) {
        var res = 0;
        var row = grid.GetLength (0);
        var col = grid.GetLength (1);
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                if (grid[i, j] == '1') {
                    res++;
                    FillWater (grid, i, j);
                }
            }
        }
        return res;
    }

    public void FillWater (char[, ] grid, int row, int col) {
        if (row < 0 || row >= grid.GetLength (0)) {
            return;
        }
        if (col < 0 || col >= grid.GetLength (1)) {
            return;
        }
        if (grid[row, col] == '0') {
            return;
        }
        grid[row, col] = '0';
        FillWater (grid, row - 1, col);
        FillWater (grid, row + 1, col);
        FillWater (grid, row, col - 1);
        FillWater (grid, row, col + 1);
    }
}