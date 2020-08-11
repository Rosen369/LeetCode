public class Solution {
    public bool CheckRecord (string s) {
        var a = 0;
        var l = 0;
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == 'A') {
                a++;
            }
            if (a > 1) {
                return false;
            }

            if (s[i] == 'L') {
                l++;
            } else {
                l = 0;
            }
            if (l > 2) {
                return false;
            }
        }
        return true;
    }
}