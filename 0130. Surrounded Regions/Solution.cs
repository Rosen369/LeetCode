public class Solution {
    public void Solve (char[, ] board) {
        var row = board.GetLength (0);
        var col = board.GetLength (1);
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                if (board[i, j] == 'O') {
                    board[i, j] = '-';
                }
            }
        }
        for (int i = 0; i < row; i++) {
            if (board[i, 0] == '-') {
                board[i, 0] = 'O';
                DFS (board, row, col, i, 0);
            }
            if (board[i, col - 1] == '-') {
                board[i, col - 1] = 'O';
                DFS (board, row, col, i, col - 1);
            }
        }
        for (int j = 0; j < col; j++) {
            if (board[0, j] == '-') {
                board[0, j] = 'O';
                DFS (board, row, col, 0, j);
            }
            if (board[row - 1, j] == '-') {
                board[row - 1, j] = 'O';
                DFS (board, row, col, row - 1, j);
            }
        }
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                if (board[i, j] == '-') {
                    board[i, j] = 'X';
                }
            }
        }
    }

    public void DFS (char[, ] board, int row, int col, int y, int x) {
        if (y - 1 > 0 && board[y - 1, x] == '-') {
            board[y - 1, x] = 'O';
            DFS (board, row, col, y - 1, x);
        }
        if (y + 1 < row && board[y + 1, x] == '-') {
            board[y + 1, x] = 'O';
            DFS (board, row, col, y + 1, x);
        }
        if (x - 1 > 0 && board[y, x - 1] == '-') {
            board[y, x - 1] = 'O';
            DFS (board, row, col, y, x - 1);
        }
        if (x + 1 < col && board[y, x + 1] == '-') {
            board[y, x + 1] = 'O';
            DFS (board, row, col, y, x + 1);
        }
    }
}