public class Solution {
    public bool SearchMatrix (int[, ] matrix, int target) {
        if (matrix == null) {
            return false;
        }
        var row = 0;
        var col = matrix.GetLength (1) - 1;
        var rowEnd = matrix.GetLength (0) - 1;
        var colEnd = 0;
        while (row <= rowEnd && col >= colEnd) {
            if (matrix[row, col] == target) {
                return true;
            } else if (matrix[row, col] > target) {
                col--;
            } else {
                row++;
            }
        }
        return false;
    }
}