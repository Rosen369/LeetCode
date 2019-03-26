public class Solution {
    public int LongestPalindrome (string s) {
        var count = new int[58];
        for (int i = 0; i < s.Length; i++) {
            count[s[i] - 'A']++;
        }
        var longest = 0;
        for (int i = 0; i < 58; i++) {
            longest += count[i] / 2 * 2;
        }
        if (longest < s.Length) {
            longest++;
        }
        return longest;
    }
}