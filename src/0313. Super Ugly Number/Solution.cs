public class Solution {
    public int NthSuperUglyNumber (int n, int[] primes) {
        if (n == 1) {
            return 1;
        }
        var dp = new int[n];
        dp[0] = 1;
        var times = new int[primes.Length];
        for (int i = 1; i < n; i++) {
            dp[i] = int.MaxValue;
            for (int t = 0; t < times.Length; t++) {
                dp[i] = Math.Min (dp[i], dp[times[t]] * primes[t]);
            }
            for (int t = 0; t < times.Length; t++) {
                if (dp[i] == dp[times[t]] * primes[t]) times[t]++;
            }
        }
        return dp[n - 1];
    }
}