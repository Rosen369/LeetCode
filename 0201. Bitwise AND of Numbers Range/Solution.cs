public class Solution {
    public int RangeBitwiseAnd (int m, int n) {
        if (m == 0) {
            return 0;
        }
        var factor = 1;
        while (m != n) {
            m >>= 1;
            n >>= 1;
            factor <<= 1;
        }
        return m * factor;
    }
}