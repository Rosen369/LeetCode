public class Solution {
    public int HammingWeight (uint n) {
        if (n == 0) {
            return 0;
        }
        var res = 0;
        while (n > 0) {
            if (n % 2 == 1) {
                res++;
            }
            n = n / 2;
        }
        return res;
    }
}