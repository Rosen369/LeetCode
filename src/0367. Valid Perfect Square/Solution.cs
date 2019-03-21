public class Solution {
    public bool IsPerfectSquare (int num) {
        var left = 1;
        var right = num;
        while (left <= right) {
            var mid = (long) (left + right) / 2;
            var sqrt = mid * mid;
            if (sqrt == num) {
                return true;
            } else if (sqrt > num) {
                right = (int) mid - 1;
            } else {
                left = (int) mid + 1;
            }
        }
        return false;
    }
}