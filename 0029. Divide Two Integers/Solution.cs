public class Solution {
    public int Divide (long dividend, long divisor) {
        var negative = (dividend > 0 && divisor < 0) || (dividend < 0 && divisor > 0);
        dividend = Math.Abs (dividend);
        divisor = Math.Abs (divisor);
        long res = 0;
        long c = 1;
        var sub = divisor;
        while (dividend >= divisor) {
            if (dividend >= sub) {
                dividend -= sub;
                res += c;
                sub = (sub << 1);
                c = (c << 1);
            } else {
                sub = (sub >> 1);
                c = (c >> 1);
            }
        }
        if (negative) {
            res = -res;
        }
        res = Math.Min (Math.Max (-2147483648, res), 2147483647);
        return (int) res;
    }
}