public class Solution {
    public bool IsMatch (string s, string p) {
        if (string.IsNullOrEmpty (p) && string.IsNullOrEmpty (s)) {
            return true;
        }
        if (string.IsNullOrEmpty (p)) {
            return false;
        }
        if (string.IsNullOrEmpty (s)) {
            for (int i = 0; i < p.Length; i++) {
                if (p[i] != '*') {
                    return false;
                }
            }
            return true;
        }
        if (p[0] == '?') {
            return IsMatch (s.Substring (1), p.Substring (1));
        }
        if (p[0] == '*') {
            if (p.Length == 1) {
                return true;
            }
            //compress '*' for speed up
            for (int i = 1; i < p.Length; i++) {
                if (p[i] != '*') {
                    p = p.Substring (i - 1);
                    break;
                }
            }
            for (int i = 0; i < s.Length; i++) {
                if (IsMatch (s.Substring (i), p.Substring (1))) {
                    return true;
                }
            }
            return false;
        }
        if (p[0] == s[0]) {
            return IsMatch (s.Substring (1), p.Substring (1));
        }
        return false;
    }
}