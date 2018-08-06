public class Solution {
    public void SetZeroes (int[, ] matrix) {
        var row = matrix.GetLength (0);
        var column = matrix.GetLength (1);
        var firstColumnHasZero = false;
        var firstRowHasZero = false;
        // use first row and column to memorize 0
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < column; j++) {
                if (matrix[i, j] == 0) {
                    if (i == 0) {
                        firstRowHasZero = true;
                    }
                    if (j == 0) {
                        firstColumnHasZero = true;
                    }
                    matrix[i, 0] = 0;
                    matrix[0, j] = 0;
                }
            }
        }
        for (int i = 1; i < row; i++) {
            for (int j = 1; j < column; j++) {
                if (matrix[i, 0] == 0 || matrix[0, j] == 0) {
                    matrix[i, j] = 0;
                }
            }
        }
        if (firstColumnHasZero) {
            for (int i = 0; i < row; i++) {
                matrix[i, 0] = 0;
            }
        }
        if (firstRowHasZero) {
            for (int i = 0; i < column; i++) {
                matrix[0, i] = 0;
            }
        }
    }
}