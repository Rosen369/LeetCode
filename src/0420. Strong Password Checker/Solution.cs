public class Solution {
    public int StrongPasswordChecker (string s) {
        var res = 0;
        var lower = 1;
        var upper = 1;
        var digit = 1;
        var arr = new int[s.Length];
        for (int i = 0; i < arr.Length;) {
            if (s[i] >= 'a' && s[i] <= 'z') lower = 0;
            if (s[i] >= 'A' && s[i] <= 'Z') upper = 0;
            if (s[i] >= '0' && s[i] <= '9') digit = 0;
            var j = i;
            while (i < s.Length && s[i] == s[j]) {
                i++;
            }
            arr[j] = i - j;
        }
        var totalMissing = lower + upper + digit;
        if (arr.Length < 6) {
            res += totalMissing + Math.Max (0, 6 - (arr.Length + totalMissing));
        } else {
            var overLen = Math.Max (arr.Length - 20, 0);
            var leftOver = 0;
            res += overLen;
            for (int k = 1; k < 3; k++) {
                for (int i = 0; i < arr.Length && overLen > 0; i++) {
                    if (arr[i] < 3 || arr[i] % 3 != (k - 1)) {
                        continue;
                    }
                    arr[i] -= Math.Min (overLen, k);
                    overLen -= k;
                }
            }
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] >= 3 && overLen > 0) {
                    var need = arr[i] - 2;
                    arr[i] -= overLen;
                    overLen -= need;
                }
                if (arr[i] >= 3) {
                    leftOver += arr[i] / 3;
                }
            }
            res += Math.Max (totalMissing, leftOver);
        }
        return res;
    }
}