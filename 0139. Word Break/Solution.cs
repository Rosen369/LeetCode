public class Solution {
    public bool WordBreak (string s, IList<string> wordDict) {
        var dp = new bool[s.Length + 1];
        dp[0] = true;
        for (int i = 0; i < s.Length; i++) {
            for (int j = 0; j < wordDict.Count (); j++) {
                if (i + wordDict[j].Length > s.Length) {
                    continue;
                }
                var sub = s.Substring (i, wordDict[j].Length);
                if (dp[i] == true && sub == wordDict[j]) {
                    dp[i + wordDict[j].Length] = true;
                }
            }
        }
        return dp[s.Length];
    }
}