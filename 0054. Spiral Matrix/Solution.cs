public class Solution {
    public IList<int> SpiralOrder (int[, ] matrix) {
        var res = new List<int> ();
        if (matrix.Length == 0) {
            return res;
        }
        var top = 0;
        var right = matrix.GetLength (1);
        var bottom = matrix.GetLength (0);
        var left = 0;
        MoveRight (0, 0, top, right, bottom, left, matrix, res);
        return res;
    }

    public void MoveRight (int x, int y, int top, int right, int bottom, int left, int[, ] matrix, IList<int> res) {
        while (x < right) {
            res.Add (matrix[y, x]);
            x++;
        }
        if (y + 1 == bottom) {
            return;
        } else {
            MoveDown (x - 1, y + 1, top + 1, right, bottom, left, matrix, res);
        }
    }

    public void MoveDown (int x, int y, int top, int right, int bottom, int left, int[, ] matrix, IList<int> res) {
        while (y < bottom) {
            res.Add (matrix[y, x]);
            y++;
        }
        if (x == left) {
            return;
        } else {
            MoveLeft (x - 1, y - 1, top, right - 1, bottom, left, matrix, res);
        }
    }

    public void MoveLeft (int x, int y, int top, int right, int bottom, int left, int[, ] matrix, IList<int> res) {
        while (x >= left) {
            res.Add (matrix[y, x]);
            x--;
        }
        if (y == top) {
            return;
        } else {
            MoveUp (x + 1, y - 1, top, right, bottom - 1, left, matrix, res);
        }
    }

    public void MoveUp (int x, int y, int top, int right, int bottom, int left, int[, ] matrix, IList<int> res) {
        while (y >= top) {
            res.Add (matrix[y, x]);
            y--;
        }
        if (x + 1 == right) {
            return;
        } else {
            MoveRight (x + 1, y + 1, top, right, bottom, left + 1, matrix, res);
        }
    }
}