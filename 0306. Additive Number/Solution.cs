public class Solution {
    public bool IsAdditiveNumber (string num) {
        for (int i = 1; i <= num.Length / 2; i++) {
            var first = num.Substring (0, i);
            if (first[0] == '0' && first.Length > 1) {
                continue;
            }
            var fn = Convert.ToInt64 (first);
            for (int j = 1; Math.Max (j, i) <= num.Length - i - j; j++) {
                var second = num.Substring (i, j);
                if (second[0] == '0' && second.Length > 1) {
                    continue;
                }
                var sn = Convert.ToInt64 (second);
                if (DFS (fn, sn, num.Substring (i + j))) {
                    return true;
                }
            }
        }
        return false;
    }

    private bool DFS (long pp, long p, string num) {
        if (string.IsNullOrEmpty (num)) {
            return true;
        }
        if (num[0] == '0' && num.Length > 1) {
            return false;
        }
        for (int i = 1; i <= num.Length; i++) {
            var left = num.Substring (0, i);
            var n = Convert.ToInt64 (left);
            if (pp + p == n) {
                var right = num.Substring (i);
                if (DFS (p, n, right)) {
                    return true;
                }
            }
        }
        return false;
    }
}