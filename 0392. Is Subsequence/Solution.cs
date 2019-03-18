public class Solution {
    public bool IsSubsequence (string s, string t) {
        var sIndex = 0;
        for (int i = 0; i < t.Length; i++) {
            if (sIndex == s.Length) {
                break;
            }
            if (s[sIndex] == t[i]) {
                sIndex++;
            }
        }
        return sIndex == s.Length;
    }
}