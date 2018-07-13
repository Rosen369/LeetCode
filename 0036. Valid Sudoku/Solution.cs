public class Solution {
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