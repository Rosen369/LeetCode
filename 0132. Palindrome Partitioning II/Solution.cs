public class Solution {
    public int MinCut (string s) {
        var len = s.Length;
        var cut = new int[len];
        var dp = new bool[len, len];
        for (int end = 0; end < len; end++) {
            var min = end;
            for (int start = 0; start <= end; start++) {
                if (s[start] == s[end]) {
                    if (start + 1 > end - 1 || dp[start + 1, end - 1]) {
                        dp[start, end] = true;
                        min = start == 0 ? 0 : Math.Min (min, cut[start - 1] + 1);
                    }
                }
            }
            cut[end] = min;
        }
        return cut[len - 1];
    }
}