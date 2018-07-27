public class Solution {
    public IList<int> SpiralOrder (int[, ] matrix) {
        var res = new List<int> ();
        if (matrix.Length == 0) {
            return res;
        }
        var top = 0;
        var right = matrix.GetLength (1) - 1;
        var bottom = matrix.GetLength (0) - 1;
        var left = 0;
        while (left <= right && top <= bottom) {
            for (int i = left; i <= right; i++) {
                res.Add (matrix[top, i]);
            }
            top++;
            for (int i = top; i <= bottom; i++) {
                res.Add (matrix[i, right]);
            }
            right--;
            if (top <= bottom) {
                for (int i = right; i >= left; i--) {
                    res.Add (matrix[bottom, i]);
                }
            }
            bottom--;
            if (left <= right) {
                for (int i = bottom; i >= top; i--) {
                    res.Add (matrix[i, left]);
                }
            }
            left++;
        }
        return res;
    }
}