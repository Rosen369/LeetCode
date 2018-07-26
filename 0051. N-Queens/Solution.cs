public class Solution {
    public IList<IList<string>> SolveNQueens (int n) {
        var res = new List<IList<string>> ();
        var chessboard = new List<string> ();
        for (int i = 0; i < n; i++) {
            chessboard.Add (new string ('.', n));
        }
        PutNextQueen (n, 0, 0, chessboard, res, 0);
        return res;
    }

    public void PutNextQueen (int n, int i, int j, IList<string> chessboard, IList<IList<string>> res, int count) {
        if (count == n) {
            res.Add (chessboard);
            return;
        }
        for (; i < n; i++) {
            for (; j < n; j++) {
                if (chessboard[i][j] != 'Q' && Valid (n, i, j, chessboard)) {
                    var copy = new List<string> (chessboard);
                    var arr = copy[i].ToCharArray ();
                    arr[j] = 'Q';
                    copy[i] = new string (arr);
                    PutNextQueen (n, i, j, copy, res, count + 1);
                }
            }
            j = 0;
        }
    }

    public bool Valid (int n, int row, int column, IList<string> chessboard) {
        for (int i = 0; i < n; i++) {
            if (chessboard[i][column] == 'Q') {
                return false;
            }
            if (chessboard[row][i] == 'Q') {
                return false;
            }
        }
        var slash = column - row;
        var backslash = column + row;
        for (int i = 0; i < n; i++) {
            if (slash >= 0 && slash < n) {
                if (chessboard[i][slash] == 'Q') {
                    return false;
                }
            }
            if (backslash >= 0 && backslash < n) {
                if (chessboard[i][backslash] == 'Q') {
                    return false;
                }
            }
            slash++;
            backslash--;
        }
        return true;
    }
}