public class Solution {
    public string SmallestGoodBase (string nn) {
        var n = Convert.ToInt64 (nn);
        var res = 0L;
        for (int k = 60; k >= 2; k--) {
            var start = 2L;
            var end = n;
            while (start < end) {
                var mid = start + (end - start) / 2;
                var left = new BigInteger (mid);
                left = BigInteger.Pow (left, k);
                left = BigInteger.Subtract (left, BigInteger.One);
                var right = BigInteger.Multiply (new BigInteger (n), BigInteger.Subtract (new BigInteger (mid), BigInteger.One));
                var cmr = left.CompareTo (right);
                if (cmr == 0) {
                    res = mid;
                    break;
                } else if (cmr < 0) {
                    start = mid + 1;
                } else {
                    end = mid;
                }
            }
            if (res != 0) break;
        }
        return res.ToString ();
    }
}