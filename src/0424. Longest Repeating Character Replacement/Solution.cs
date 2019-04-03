public class Solution {
    public int CharacterReplacement (string s, int k) {
        var res = 0;
        for (int left = 0; left < s.Length; left++) {
            var replace = k;
            var len = 0;
            var right = left;
            while (right < s.Length) {
                if (s[left] == s[right]) {
                    len++;
                    right++;
                } else if (replace > 0) {
                    if (replace == k) {
                        left = right - 1;
                    }
                    len++;
                    right++;
                    replace--;
                } else {
                    break;
                }
            }
            if (replace > 0) {
                len += replace;
            }
            res = Math.Max (res, len);
            res = Math.Min (res, s.Length);
        }
        return res;
    }
}