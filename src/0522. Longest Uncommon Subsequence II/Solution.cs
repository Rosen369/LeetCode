public class Solution {
    public int FindLUSlength (string[] strs) {
        var res = -1;
        var n = strs.Length;
        for (int i = 0; i < n; i++) {
            if (strs[i].Length < res) {
                continue;
            }
            var j = 0;
            while (j < n) {
                if (i != j && IsSubsequence (strs[i], strs[j])) {
                    break;
                }
                j++;
            }
            if (j == n) {
                res = Math.Max (res, strs[i].Length);
            }
        }
        return res;
    }

    public bool IsSubsequence (string a, string b) {
        var i = 0;
        var j = 0;
        while (i < a.Length && j < b.Length) {
            if (a[i] == b[j]) {
                i++;
            }
            j++;
        }
        return i == a.Length;
    }
}