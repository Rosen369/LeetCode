public class Solution {
    public int[, ] GenerateMatrix (int n) {
        var res = new int[n, n];
        var top = 0;
        var right = n - 1;
        var bottom = n - 1;
        var left = 0;
        var num = 1;
        while (left <= right && top <= bottom) {
            for (int i = left; i <= right; i++) {
                res[top, i] = num++;
            }
            top++;
            for (int i = top; i <= bottom; i++) {
                res[i, right] = num++;
            }
            right--;
            if (top <= bottom) {
                for (int i = right; i >= left; i--) {
                    res[bottom, i] = num++;
                }
            }
            bottom--;
            if (left <= right) {
                for (int i = bottom; i >= top; i--) {
                    res[i, left] = num++;
                }
            }
            left++;
        }
        return res;
    }
}