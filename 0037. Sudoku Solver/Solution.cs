public class Solution {
    public void SolveSudoku (char[, ] board) {
        var candidate = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        FillAndValid (board, candidate, 0, 0);
    }

    public void FillAndValid (char[, ] board, char[] candidate, int x, int y) {
        Console.WriteLine ("x:{0},y:{1}", x, y);
        if (board[x, y] != '.') {
            if (x == 8 && y == 8) {
                return;
            }
            if (x == 8) {
                FillAndValid (board, candidate, 0, y + 1);
            } else {
                FillAndValid (board, candidate, x + 1, y);
            }
        } else {
            for (int i = 0; i < 9; i++) {
                board[x, y] = candidate[i];
                if (IsValidSudoku (board)) {
                    if (x == 8 && y == 8) {
                        return;
                    }
                    if (x == 8) {
                        FillAndValid (board, candidate, 0, y + 1);
                    } else {
                        FillAndValid (board, candidate, x + 1, y);
                    }
                } else if (i == 8) {
                    board[x, y] = '.';
                }
            }
        }
    }

    public bool IsValidSudoku (char[, ] board) {
        // valid each row
        for (int row = 0; row < 9; row++) {
            var list = new List<char> ();
            for (int i = 0; i < 9; i++) {
                if (board[i, row] == '.') {
                    continue;
                }
                if (list.Contains (board[i, row])) {
                    return false;
                } else {
                    list.Add (board[i, row]);
                }
            }
        }
        // valid each column
        for (int column = 0; column < 9; column++) {
            var list = new List<char> ();
            for (int i = 0; i < 9; i++) {
                if (board[column, i] == '.') {
                    continue;
                }
                if (list.Contains (board[column, i])) {
                    return false;
                } else {
                    list.Add (board[column, i]);
                }
            }
        }
        // valid each box
        for (int boxRow = 0; boxRow < 3; boxRow++) {
            for (int boxColumn = 0; boxColumn < 3; boxColumn++) {
                var list = new List<char> ();
                for (int row = 0; row < 3; row++) {
                    for (int column = 0; column < 3; column++) {
                        var x = boxColumn * 3 + column;
                        var y = boxRow * 3 + row;
                        if (board[x, y] == '.') {
                            continue;
                        }
                        if (list.Contains (board[x, y])) {
                            return false;
                        } else {
                            list.Add (board[x, y]);
                        }
                    }
                }
            }
        }
        return true;
    }
}