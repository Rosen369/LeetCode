using System;

public class Solution {
    public IList<string> ReadBinaryWatch (int num) {
        var res = new List<string> ();
        BackTracking (new int[4], new int[6], res, num, 0, 0);
        return res;
    }

    private void BackTracking (int[] hour, int[] minute, IList<string> res, int num, int count, int p) {
        if (num == count) {
            this.AddTime (hour, minute, res);
        }
        for (int i = p; i < 4; i++) {
            if (hour[i] != 1) {
                hour[i] = 1;
                BackTracking (hour, minute, res, num, count + 1, i + 1);
                hour[i] = 0;
            }
        }
        for (int i = p - 4; i < 6; i++) {
            if (i < 0) {
                continue;
            }
            if (minute[i] != 1) {
                minute[i] = 1;
                BackTracking (hour, minute, res, num, count + 1, i + 5);
                minute[i] = 0;
            }
        }
    }

    private void AddTime (int[] hour, int[] minute, IList<string> res) {
        var h = hour[0] * 8 + hour[1] * 4 + hour[2] * 2 + hour[3];
        var m = minute[0] * 32 + minute[1] * 16 + minute[2] * 8 + minute[3] * 4 + minute[4] * 2 + minute[5] * 1;
        if (h > 11 || m > 59) {
            return;
        }
        var t = h + ":" + m.ToString ("D2");
        res.Add (t);
    }
}