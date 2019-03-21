public class Solution {
    public int IntegerReplacement (int n) {
        if (n == int.MaxValue) {
            return 32;
        }
        var res = 0;
        while (n > 1) {
            res++;
            if (n % 2 == 0) {
                n = n / 2;
            } else if (n % 4 == 1 || n == 3) {
                n--;
            } else {
                n++;
            }
        }
        return res;
    }
}