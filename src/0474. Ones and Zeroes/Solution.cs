public class Solution {
    public int FindMaxForm (string[] strs, int m, int n) {
        var dp = new int[m + 1, n + 1];
        var res = 0;
        foreach (var s in strs) {
            var count = this.Count (s);
            for (int i = m; i >= count[0]; i--)
                for (int j = n; j >= count[1]; j--) {
                    dp[i, j] = Math.Max (1 + dp[i - count[0], j - count[1]], dp[i, j]);
                }
        }
        return dp[m, n];
    }

    private int[] Count (string s) {
        var res = new int[2];
        for (int i = 0; i < s.Length; i++)
            res[s[i] - '0']++;
        return res;
    }
}