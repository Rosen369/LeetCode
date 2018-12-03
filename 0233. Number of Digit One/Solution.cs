public class Solution {
    public int CountDigitOne (int n) {
        int ones = 0;
        for (long m = 1; m <= n; m *= 10) {
            var a = n / m;
            var b = n % m;
            ones += (int) ((a + 8) / 10 * m);
            if (a % 10 == 1) {
                ones += (int) b + 1;
            }
        }
        return ones;
    }
}