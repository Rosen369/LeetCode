public class Solution {
    public int Fib (int N) {
        var dp = new int[N + 1];
        return FibDP (N, dp);
    }

    public int FibDP (int N, int[] dp) {
        if (N < 2) {
            return N;
        }
        if (dp[N] != 0) {
            return dp[N];
        }
        dp[N] = FibDP (N - 2, dp) + FibDP (N - 1, dp);
        return dp[N];
    }
}