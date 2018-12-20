public class Solution {
    public int NthUglyNumber (int n) {
        if (n == 1) {
            return 1;
        }
        var res = new int[n];
        res[0] = 1;
        var t2 = 0;
        var t3 = 0;
        var t5 = 0;
        for (int i = 1; i < n; i++) {
            res[i] = Math.Min (res[t2] * 2, (Math.Min (res[t3] * 3, res[t5] * 5)));
            if (res[i] == res[t2] * 2) t2++;
            if (res[i] == res[t3] * 3) t3++;
            if (res[i] == res[t5] * 5) t5++;
        }
        return res[n - 1];
    }
}