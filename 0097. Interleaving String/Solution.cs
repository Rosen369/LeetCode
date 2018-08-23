public class Solution {
    public bool IsInterleave (string s1, string s2, string s3) {
        return Interleave (s1, s2, s3) || Interleave (s2, s1, s3);
    }

    public bool Interleave (string s1, string s2, string s3) {
        if (string.IsNullOrEmpty (s1)) {
            return s2 == s3;
        }
        if (s1.Length >= s3.Length) {
            return false;
        }
        for (int i = 1; i <= s1.Length; i++) {
            var s1Left = s1.Substring (0, i);
            var s3Left = s3.Substring (0, i);
            if (s1Left == s3Left) {
                var s1Right = s1.Substring (i);
                var s3Right = s3.Substring (i);
                if (IsInterleave (s2, s1Right, s3Right)) {
                    return true;
                }
            } else {
                break;
            }
        }
        return false;
    }
}