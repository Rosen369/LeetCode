public class Solution {
    public int Compress (char[] chars) {
        if (chars.Length == 0) {
            return 0;
        }
        var res = 0;
        var pre = chars[0];
        var count = 1;
        var current = 0;
        for (int i = 1; i <= chars.Length; i++) {
            var c = '0';
            if (i < chars.Length) {
                c = chars[i];
            }
            if (c == pre) {
                count++;
                continue;
            }
            chars[current++] = pre;
            res++;
            if (count > 1) {
                var digits = count.ToString ();
                for (int j = 0; j < digits.Length; j++) {
                    chars[current++] = digits[j];
                    res++;
                }
            }
            pre = c;
            count = 1;
        }
        return res;
    }
}