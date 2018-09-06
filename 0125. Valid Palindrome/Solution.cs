public class Solution {
    public bool IsPalindrome (string s) {
        s = s.ToLower ();
        var start = 0;
        var end = s.Length - 1;
        while (start < end) {
            if (!Char.IsLetterOrDigit (s[start])) {
                start++;
                continue;
            }
            if (!Char.IsLetterOrDigit (s[end])) {
                end--;
                continue;
            }
            if (s[start] != s[end]) {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
}