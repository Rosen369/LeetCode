public class Solution {
    public int LongestPalindrome (string s) {
        var count = new int[58];
        for (int i = 0; i < s.Length; i++) {
            count[s[i] - 'A']++;
        }
        var longest = 0;
        for (int i = 0; i < 58; i++) {
            if (count[i] == 0) {
                continue;
            }
            if (longest % 2 == 0) {
                longest += count[i];
            } else if (count[i] > 1) {
                longest += count[i] / 2 * 2;
            }
        }
        return longest;
    }
}