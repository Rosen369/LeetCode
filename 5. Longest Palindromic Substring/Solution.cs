public class Solution {
    public string LongestPalindrome (string s) {
        var longest = string.Empty;
        for (var i = 0; i < s.Length; i++) {
            var p1 = GetPalindrome (s, i, i);
            var p2 = GetPalindrome (s, i, i + 1);
            if (p1 > longest.Length) {
                longest = s.Substring (i - (p1 - 1) / 2, p1);
            }
            if (p2 > longest.Length) {
                longest = s.Substring (i - p2 / 2 + 1, p2);
            }
        }
        return longest;
    }

    public int GetPalindrome (string s, int left, int right) {
        var length = 0;
        while (left >= 0 && right < s.Length && s[left] == s[right]) {
            length = right - left + 1;
            left--;
            right++;
        }
        return length;
    }
}