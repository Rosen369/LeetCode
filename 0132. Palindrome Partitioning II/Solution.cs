public class Solution {
    public int MinCut (string s) {
        if (string.IsNullOrEmpty (s)) {
            return 0;
        }
        var dic = new Dictionary<string, int> ();
        BackTrack (s, dic);
        return dic[s];
    }

    public void BackTrack (string s, Dictionary<string, int> dic) {
        if (dic.ContainsKey (s)) {
            return;
        }
        if (IsPalindrome (s)) {
            dic.Add (s, 0);
            return;
        }
        var min = s.Length;
        for (int i = 1; i <= s.Length - 1; i++) {
            var left = s.Substring (0, i);
            var right = s.Substring (i);
            if (IsPalindrome (left)) {
                BackTrack (right, dic);
                min = Math.Min (min, dic[right]);
            }
        }
        dic.Add (s, 1 + min);
    }

    public bool IsPalindrome (string s) {
        for (int i = 0; i < s.Length / 2; i++) {
            if (s[i] != s[s.Length - 1 - i]) {
                return false;
            }
        }
        return true;
    }
}