public class Solution {
    public int CheckRecord (int n) {
        if (n == 1) {
            return 3;
        }
        if (n == 2) {
            return 8;
        }
        if (n == 3) {
            return 19;
        }

        var mod = 1000000007;
        var P = new int[n];
        var L = new int[n];
        var A = new int[n];

        P[0] = 1;
        P[1] = 3;
        P[2] = 8;
        L[0] = 1;
        L[1] = 3;
        L[2] = 7;
        A[0] = 1;
        A[1] = 2;
        A[2] = 4;

        for (int i = 3; i < n; i++) {
            P[i] = (A[i - 1] + P[i - 1]) % mod + L[i - 1];
            P[i] %= mod;
            L[i] = (A[i - 1] + P[i - 1]) % mod + (A[i - 2] + P[i - 2]) % mod;
            L[i] %= mod;
            A[i] = (A[i - 1] + A[i - 2]) % mod + A[i - 3];
            A[i] %= mod;
        }

        return ((P[n - 1] + L[n - 1]) % mod + A[n - 1]) % mod;
    }
}