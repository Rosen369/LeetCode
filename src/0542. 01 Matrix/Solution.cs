public class Solution {
    public int[][] UpdateMatrix (int[][] matrix) {
        var row = matrix.Length;
        var col = matrix[0].Length;
        var queue = new Queue<int[]> ();
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                if (matrix[i][j] == 1) {
                    matrix[i][j] = -1;
                } else {
                    queue.Enqueue (new int[] { i, j });
                }
            }
        }
        while (queue.Count > 0) {
            this.BFS (matrix, queue);
        }
        return matrix;
    }

    private void BFS (int[][] matrix, Queue<int[]> queue) {
        var p = queue.Dequeue ();
        var directions = new int[][] { new int[] {-1, 0 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { 0, 1 } };
        for (int i = 0; i < 4; i++) {
            var d = directions[i];
            var x = p[1] + d[0];
            var y = p[0] + d[1];
            if (x < 0 || x >= matrix[0].Length) {
                continue;
            }
            if (y < 0 || y >= matrix.Length) {
                continue;
            }
            if (matrix[y][x] >= 0) {
                continue;
            }
            matrix[y][x] = matrix[p[0]][p[1]] + 1;
            queue.Enqueue (new int[] { y, x });
        }
    }
}