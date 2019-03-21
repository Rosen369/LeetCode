public class Solution {
    public IList<IList<string>> SolveNQueens (int n) {
        var res = new List<IList<string>> ();
        char[][] chessboard = new char[n][];
        for (int i = 0; i < n; i++) {
            chessboard[i] = new char[n];
            for (int j = 0; j < n; j++) {
                chessboard[i][j] = '.';
            }
        }
        PutNextQueen (n, 0, 0, chessboard, res, 0);
        return res;
    }

    public void PutNextQueen (int n, int i, int j, char[][] chessboard, IList<IList<string>> res, int count) {
        if (count == n) {
            var list = new List<string> ();
            for (int r = 0; r < n; r++) {
                list.Add (new string (chessboard[r]));
            }
            res.Add (list);
            return;
        }
        for (; i < n; i++) {
            for (; j < n; j++) {
                if (chessboard[i][j] != 'Q' && Valid (n, i, j, chessboard)) {
                    chessboard[i][j] = 'Q';
                    PutNextQueen (n, i, j, chessboard, res, count + 1);
                    chessboard[i][j] = '.';
                }
            }
            j = 0;
        }
    }

    public bool Valid (int n, int row, int column, char[][] chessboard) {
        var slash = column - row;
        var backslash = column + row;
        for (int i = 0; i < n; i++) {
            if (chessboard[i][column] == 'Q') {
                return false;
            }
            if (chessboard[row][i] == 'Q') {
                return false;
            }
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