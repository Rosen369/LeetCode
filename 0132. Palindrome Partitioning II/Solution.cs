public class Solution {
    public int MinCut (string s) {
        var min = s.Length - 1;
        min = BackTrack (s, 0, min);
        return min;
    }

    public int BackTrack (string s, int step, int min) {
        if (string.IsNullOrEmpty (s)) {
            return 0;
        }
        if (step >= min) {
            return step;
        }
        if (IsPalindrome (s)) {
            return step;
        }
        for (int i = 1; i <= s.Length - 1; i++) {
            var left = s.Substring (0, i);
            var right = s.Substring (i);
            if (IsPalindrome (left)) {
                var res = BackTrack (right, step + 1, min);
                min = Math.Min (min, res);
            }
        }
        return min;
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