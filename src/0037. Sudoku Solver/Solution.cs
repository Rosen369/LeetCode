public class Solution {
    public void SolveSudoku (char[, ] board) {
        FillSudoku (board);
    }

    public bool FillSudoku (char[, ] board) {
        for (int x = 0; x < 9; x++) {
            for (int y = 0; y < 9; y++) {
                if (board[x, y] == '.') {
                    for (char c = '1'; c <= '9'; c++) {
                        board[x, y] = (char) c;
                        if (ValidSudoku (board, x, y)) {
                            if (FillSudoku (board)) {
                                return true;
                            }
                        }
                    }
                    board[x, y] = '.';
                    return false;
                }
            }
        }
        return true;
    }

    public bool ValidSudoku (char[, ] board, int x, int y) {
        // valid row
        for (int i = 0; i < 9; i++) {
            if (i == x) {
                continue;
            }
            if (board[i, y] == '.') {
                continue;
            }
            if (board[i, y] == board[x, y]) {
                return false;
            }
        }
        // valid column
        for (int i = 0; i < 9; i++) {
            if (i == y) {
                continue;
            }
            if (board[x, i] == '.') {
                continue;
            }
            if (board[x, i] == board[x, y]) {
                return false;
            }
        }
        // valid box
        for (int row = y / 3 * 3; row < y / 3 * 3 + 3; row++) {
            for (int column = x / 3 * 3; column < x / 3 * 3 + 3; column++) {
                if (column == x && row == y) {
                    continue;
                }
                if (board[column, row] == '.') {
                    continue;
                }
                if (board[column, row] == board[x, y]) {
                    return false;
                }
            }
        }
        return true;
    }
}