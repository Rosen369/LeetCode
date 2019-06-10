public class Solution {
    public int FindSubstringInWraproundString (string p) {
        var count = new int[26];
        var max = 0;
        for (int i = 0; i < p.Length; i++) {
            if (i == 0) {
                max = 1;
            } else if (p[i] - p[i - 1] == 1 || p[i - 1] - p[i] == 25) {
                max++;
            } else {
                max = 1;
            }
            var pos = p[i] - 'a';
            count[pos] = Math.Max (max, count[pos]);
        }
        var sum = 0;
        for (int i = 0; i < 26; i++) {
            sum += count[i];
        }
        return sum;
    }
}