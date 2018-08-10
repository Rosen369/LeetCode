public class Solution {
    public bool Exist (char[, ] board, string word) {
        var row = board.GetLength (0);
        var col = board.GetLength (1);
        var path = new int[row, col];
        for (int y = 0; y < row; y++) {
            for (int x = 0; x < col; x++) {
                if (FindNext (board, word, 0, x, y, path)) {
                    return true;
                }
            }
        }
        return false;
    }

    public bool FindNext (char[, ] board, string word, int index, int x, int y, int[, ] path) {
        if (index == word.Length) {
            return true;
        }
        if (x < 0 || x >= board.GetLength (1) || y < 0 || y >= board.GetLength (0)) {
            return false;
        }
        if (board[y, x] != word[index]) {
            return false;
        }
        if (path[y, x] == 1) {
            return false;
        }
        path[y, x] = 1;
        if (FindNext (board, word, index + 1, x + 1, y, path)) {
            return true;
        }
        if (FindNext (board, word, index + 1, x - 1, y, path)) {
            return true;
        }
        if (FindNext (board, word, index + 1, x, y + 1, path)) {
            return true;
        }
        if (FindNext (board, word, index + 1, x, y - 1, path)) {
            return true;
        }
        path[y, x] = 0;
        return false;
    }
}