public class Solution {
    public int MinDistance (string word1, string word2) {
        var s1 = word1.Length;
        var s2 = word2.Length;
        var dp = new int[s1 + 1, s2 + 1];
        for (int i = 0; i <= s1; i++) {
            for (int j = 0; j <= s2; j++) {
                if (i == 0 && j == 0) {
                    dp[i, j] = 0;
                } else if (i == 0 && j != 0) {
                    dp[i, j] = j;
                } else if (i != 0 && j == 0) {
                    dp[i, j] = i;
                } else if (word1[i - 1] != word2[j - 1]) {
                    var min = Math.Min (dp[i - 1, j], dp[i, j - 1]);
                    min = Math.Min (dp[i - 1, j - 1], min);
                    dp[i, j] = min + 1;
                } else {
                    dp[i, j] = dp[i - 1, j - 1];
                }
            }
        }
        return dp[s1, s2];
    }
}