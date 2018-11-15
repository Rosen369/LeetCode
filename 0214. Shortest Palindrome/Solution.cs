public class Solution {
    public string ShortestPalindrome (string s) {
        var revArr = s.ToCharArray ();
        Array.Reverse (revArr);
        var rev = new string (revArr);
        var p = s + "#" + rev;
        var f = new int[p.Length];
        for (int i = 1; i < p.Length; i++) {
            var t = f[i - 1];
            while (t > 0 && p[i] != p[t]) {
                t = f[t - 1];
            }
            if (p[i] == p[t]) {
                ++t;
            }
            f[i] = t;
        }
        return rev.Substring (0, s.Length - f[p.Length - 1]) + s;
    }
}