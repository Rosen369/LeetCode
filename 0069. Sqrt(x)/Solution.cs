public class Solution {
    public int MySqrt (int x) {
        if (x == 1) {
            return 1;
        }
        long left = 1;
        long right = x;
        while (left <= right) {
            long mid = (left + right) / 2;
            long sqrt = mid * mid;
            if (sqrt == x) {
                return (int) mid;
            }
            if (sqrt < x) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        return (int) left - 1;
    }
}