public class Solution {
    public bool RepeatedSubstringPattern (string s) {
        var len = s.Length;
        for (int i = 1; i <= len / 2; i++) {
            if (len % i != 0) continue;
            var sub = s.Substring (0, i);
            var subIndex = 0;
            var succeed = true;
            for (int j = 0; j < len; j++) {
                if (s[j] != sub[subIndex]) {
                    succeed = false;
                    break;
                }
                subIndex = subIndex == sub.Length - 1 ? 0 : subIndex + 1;
            }
            if (succeed) return true;
        }
        return false;
    }
}