public class Solution {
    public IList<IList<string>> Partition (string s) {
        var res = new List<IList<string>> ();
        if (string.IsNullOrEmpty (s)) {
            return res;
        }
        BackTrack (s, new List<string> (), res);
        return res;
    }

    public void BackTrack (string s, IList<string> curr, IList<IList<string>> res) {
        if (string.IsNullOrEmpty (s)) {
            return;
        }
        if (IsPalindrome (s)) {
            var clone = new List<string> (curr);
            clone.Add (s);
            res.Add (clone);
        }
        for (int i = 1; i <= s.Length - 1; i++) {
            var left = s.Substring (0, i);
            var right = s.Substring (i);
            if (IsPalindrome (left)) {
                curr.Add (left);
                BackTrack (right, curr, res);
                curr.RemoveAt (curr.Count () - 1);
            }
        }
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