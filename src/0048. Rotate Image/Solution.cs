public class Solution {
    public void Rotate (int[, ] matrix) {
        var edge = matrix.GetLength (0);
        for (int i = 0; i < edge / 2; i++) {
            for (int j = 0; j < edge; j++) {
                var temp = matrix[i, j];
                matrix[i, j] = matrix[edge - i - 1, j];
                matrix[edge - 1 - i, j] = temp;
            }
        }
        for (int i = 0; i < edge; i++) {
            for (int j = i + 1; j < edge; j++) {
                var temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }
    }
}