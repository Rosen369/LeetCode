public class Solution {
    // DFS solution
    //Runtime: 304 ms
    //Memory Usage: 32.4 MB
    public IList<int[]> PacificAtlantic (int[][] matrix) {
        var res = new List<int[]> ();
        if (matrix.Length == 0 || matrix[0].Length == 0) {
            return res;
        }
        var m = matrix.Length;
        var n = matrix[0].Length;
        var pacific = new bool[m, n];
        var atlantic = new bool[m, n];
        for (int i = 0; i < m; i++) {
            DFS (matrix, pacific, i, 0);
            DFS (matrix, atlantic, i, n - 1);
        }
        for (int i = 0; i < n; i++) {
            DFS (matrix, pacific, 0, i);
            DFS (matrix, atlantic, m - 1, i);
        }
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (pacific[i, j] && atlantic[i, j]) {
                    res.Add (new int[] { i, j });
                }
            }
        }
        return res;
    }

    public void DFS (int[][] matrix, bool[, ] sea, int i, int j) {
        var m = sea.GetLength (0);
        var n = sea.GetLength (1);
        var directions = new int[, ] { {-1, 0 }, { 1, 0 }, { 0, -1 }, { 0, 1 } };
        sea[i, j] = true;
        for (int d = 0; d < 4; d++) {
            var x = j + directions[d, 1];
            var y = i + directions[d, 0];
            if (y < 0 || y >= m || x < 0 || x >= n) {
                continue;
            }
            if (matrix[i][j] > matrix[y][x]) {
                continue;
            }
            if (sea[y, x]) {
                continue;
            }
            DFS (matrix, sea, y, x);
        }
    }
}