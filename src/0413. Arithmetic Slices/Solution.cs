public class Solution {
    public int NumberOfArithmeticSlices (int[] A) {
        var len = A.Length;
        var dp = new int[len];
        var sum = 0;
        for (int i = 2; i < len; i++) {
            if (A[i - 2] - A[i - 1] == A[i - 1] - A[i]) {
                dp[i] = dp[i - 1] + 1;
                sum += dp[i];
            }
        }
        return sum;
    }
}