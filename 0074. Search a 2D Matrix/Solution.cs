public class Solution {
    public bool SearchMatrix (int[, ] matrix, int target) {
        if (matrix.Length == 0) {
            return false;
        }
        var m = matrix.GetLength (0);
        var n = matrix.GetLength (1);
        var left = 0;
        var right = matrix.Length - 1;
        while (left < right) {
            var mid = (left + right) / 2;
            var curr = matrix[mid / n, mid % n];
            if (curr < target) {
                left = mid + 1;
            } else {
                right = mid;
            }
        }
        return matrix[right / n, right % n] == target;
    }
}