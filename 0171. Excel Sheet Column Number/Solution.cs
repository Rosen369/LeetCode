public class Solution {
    public int TitleToNumber (string s) {
        var res = 0;
        var multi = 1;
        for (int i = s.Length - 1; i >= 0; i--) {
            res += ((int) s[i] - 64) * multi;
            multi *= 26;
        }
        return res;
    }
}