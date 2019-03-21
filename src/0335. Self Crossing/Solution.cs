public class Solution {
    public bool IsSelfCrossing (int[] x) {
        if (x.Length < 4) {
            return false;
        }
        var b = x[2];
        var c = x[1];
        var d = x[0];
        var e = 0;
        var f = 0;
        for (int i = 3; i < x.Length; i++) {
            var a = x[i];
            if (d >= b) {
                if (a >= c) {
                    return true;
                }
                if (a >= c - e && c - e >= 0 && f >= d - b) {
                    return true;
                }
            }
            f = e;
            e = d;
            d = c;
            c = b;
            b = a;
        }
        return false;
    }
}
/*
            b                              b
   +----------------+             +----------------+
   |                |             |                |
   |                |             |                | a
 c |                |           c |                |
   |                | a           |                |    f
   +----------->    |             |                | <----+
            d       |             |                |      | e
                    |             |                       |
                                  +-----------------------+
                                               d
 */