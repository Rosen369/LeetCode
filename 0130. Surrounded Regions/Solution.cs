public class Solution {
    public void Solve (char[, ] board) {
        var row = board.GetLength (0);
        var col = board.GetLength (1);
        var dp = new bool[row, col];
        for (int i = 0; i < row; i++) {
            if (board[i, 0] == 'O') {
                dp[i, 0] = true;
                DFS (dp, board, row, col, i, 0);
            }
            if (board[i, col - 1] == 'O') {
                dp[i, col - 1] = true;
                DFS (dp, board, row, col, i, col - 1);
            }
        }
        for (int j = 0; j < col; j++) {
            if (board[0, j] == 'O') {
                dp[0, j] = true;
                DFS (dp, board, row, col, 0, j);
            }
            if (board[row - 1, j] == 'O') {
                dp[row - 1, j] = true;
                DFS (dp, board, row, col, row - 1, j);
            }
        }
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                if (dp[i, j] == false) {
                    board[i, j] = 'X';
                }
            }
        }
    }

    public void DFS (bool[, ] dp, char[, ] board, int row, int col, int y, int x) {
        if (y - 1 > 0) {
            if (dp[y - 1, x] != true && board[y - 1, x] == 'O') {
                dp[y - 1, x] = true;
                DFS (dp, board, row, col, y - 1, x);
            }
        }
        if (y + 1 < row) {
            if (dp[y + 1, x] != true && board[y + 1, x] == 'O') {
                dp[y + 1, x] = true;
                DFS (dp, board, row, col, y + 1, x);
            }
        }
        if (x - 1 > 0) {
            if (dp[y, x - 1] != true && board[y, x - 1] == 'O') {
                dp[y, x - 1] = true;
                DFS (dp, board, row, col, y, x - 1);
            }
        }
        if (x + 1 < col) {
            if (dp[y, x + 1] != true && board[y, x + 1] == 'O') {
                dp[y, x + 1] = true;
                DFS (dp, board, row, col, y, x + 1);
            }
        }
    }
}