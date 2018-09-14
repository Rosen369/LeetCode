public class Solution {
    public int MinCut (string s) {
        var len = s.Length;
        var cut = new int[len];
        var dp = new bool[len, len];
        for (int i = 0; i < len; i++) {
            var min = i;
            for (int j = 0; j <= i; j++) {
                if (s[j] == s[i]) {
                    if (j + 1 > i - 1 || dp[j + 1, i - 1]) {
                        dp[j, i] = true;
                        min = j == 0 ? 0 : Math.Min (min, cut[j - 1] + 1);
                    }
                }
            }
            cut[i] = min;
        }
        return cut[len - 1];
    }
}