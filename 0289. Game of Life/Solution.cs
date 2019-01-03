public class Solution {
    public void GameOfLife (int[][] board) {
        var m = board.Length;
        var n = board[0].Length;
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                var count = GetCount (board, i, j);
                if (count < 2) {
                    board[i][j] = 0 * 10 + board[i][j];
                } else if (count == 2) {
                    board[i][j] = board[i][j] * 10 + board[i][j];
                } else if (count == 3) {
                    board[i][j] = 1 * 10 + board[i][j];
                } else {
                    board[i][j] = 0 * 10 + board[i][j];
                }
            }
        }
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                board[i][j] = board[i][j] / 10;
            }
        }
    }

    private int GetCount (int[][] board, int i, int j) {
        var m = board.Length;
        var n = board[0].Length;
        var count = 0;
        if (i > 0 && j > 0 && board[i - 1][j - 1] % 10 == 1) {
            count++;
        }
        if (i > 0 && board[i - 1][j] % 10 == 1) {
            count++;
        }
        if (i > 0 && j + 1 < n && board[i - 1][j + 1] % 10 == 1) {
            count++;
        }
        if (j > 0 && board[i][j - 1] % 10 == 1) {
            count++;
        }
        if (j + 1 < n && board[i][j + 1] % 10 == 1) {
            count++;
        }
        if (i + 1 < m && j > 0 && board[i + 1][j - 1] % 10 == 1) {
            count++;
        }
        if (i + 1 < m && board[i + 1][j] % 10 == 1) {
            count++;
        }
        if (i + 1 < m && j + 1 < n && board[i + 1][j + 1] % 10 == 1) {
            count++;
        }
        return count;
    }
}