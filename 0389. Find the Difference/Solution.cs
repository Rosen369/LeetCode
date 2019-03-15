public class Solution {
    public char FindTheDifference (string s, string t) {
        var sum = 0;
        for (int i = 0; i < s.Length; i++) {
            sum += s[i];
        }
        for (int i = 0; i < t.Length; i++) {
            sum -= t[i];
        }
        return (char) - sum;
    }
}