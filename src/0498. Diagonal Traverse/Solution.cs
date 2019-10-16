public class Solution {
    public int[] FindDiagonalOrder (int[][] matrix) {
        if (matrix.Length == 0) return new int[0];
        var m = matrix.Length;
        var n = matrix[0].Length;
        var res = new int[m * n];
        var col = 0;
        var row = 0;
        var d = 1;

        for (int i = 0; i < m * n; i++) {
            res[i] = matrix[row][col];
            row -= d;
            col += d;

            if (row >= m) { row = m - 1; col += 2; d = -d; }
            if (col >= n) { col = n - 1; row += 2; d = -d; }
            if (row < 0) { row = 0; d = -d; }
            if (col < 0) { col = 0; d = -d; }
        }
        return res;
    }
}