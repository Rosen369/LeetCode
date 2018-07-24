public class Solution {
    public double MyPow (double x, int n) {
        var res = 1d;
        if (n == 0) {
            return res;
        }
        if (n < 0) {
            x = 1 / x;
            n = -n;
        }
        for (int i = 0; i < n; i++) {
            res = res * x;
        }
        return res;
    }
}