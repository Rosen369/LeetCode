public class Solution {
    public int LongestSubstring (string s, int k) {
        if (string.IsNullOrEmpty (s)) {
            return 0;
        }
        var count = new int[26];
        for (int i = 0; i < s.Length; i++) {
            count[s[i] - 'a']++;
        }
        var lessThanK = new List<char> ();
        for (int i = 0; i < 26; i++) {
            if (count[i] != 0 && count[i] < k) {
                var c = (char) ('a' + i);
                lessThanK.Add (c);
            }
        }
        if (lessThanK.Count == 0) {
            return s.Length;
        }
        var max = 0;
        var split = s.Split (lessThanK.ToArray ());
        for (int i = 0; i < split.Length; i++) {
            max = Math.Max (max, LongestSubstring (split[i], k));
        }
        return max;
    }
}