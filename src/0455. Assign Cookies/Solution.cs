public class Solution {
    public int FindContentChildren (int[] g, int[] s) {
        var res = 0;
        Array.Sort (g);
        Array.Reverse (g);
        Array.Sort (s);
        Array.Reverse (s);
        var gIndex = 0;
        var sIndex = 0;
        while (gIndex < g.Length && sIndex < s.Length) {
            if (g[gIndex] <= s[sIndex]) {
                sIndex++;
                res++;
            }
            gIndex++;
        }
        return res;
    }
}