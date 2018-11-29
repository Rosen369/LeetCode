public class Solution {
    public int Calculate (string s) {
        s = s.Replace (" ", "");
        var smd = s.Replace ('+', ' ').Replace ('-', ' ');
        var mul = smd.Split (' ').ToList ();
        mul = mul.OrderByDescending (e => e.Length).ToList ();
        for (int i = 0; i < mul.Count (); i++) {
            var ms = mul[i];
            if (!ms.Contains ('/') && !ms.Contains ('*')) {
                continue;
            }
            var mr = 1;
            var mn = 0;
            var mo = '*';
            for (int j = 0; j < ms.Length; j++) {
                if (char.IsDigit (ms[j])) {
                    mn = mn * 10 + (int) (ms[j] - '0');
                } else {
                    if (mo == '*') {
                        mr = mr * mn;
                    } else {
                        mr = mr / mn;
                    }
                    mn = 0;
                    mo = ms[j];
                }
            }
            if (mo == '*') {
                mr = mr * mn;
            } else {
                mr = mr / mn;
            }
            s = s.Replace (ms, mr.ToString ());
        }
        var res = 0;
        var opt = 1;
        var num = 0;
        for (int i = 0; i < s.Length; i++) {
            if (char.IsDigit (s[i])) {
                num = num * 10 + (int) (s[i] - '0');
            } else if (s[i] == '+') {
                res += num * opt;
                num = 0;
                opt = 1;
            } else if (s[i] == '-') {
                res += num * opt;
                num = 0;
                opt = -1;
            }
        }
        res += num * opt;
        return res;
    }
}