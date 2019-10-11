public class Solution {
    public int FindPoisonedDuration (int[] timeSeries, int duration) {
        if (timeSeries.Length == 0) return 0;
        var res = 0;
        var s = timeSeries[0];
        var e = timeSeries[0] + duration;
        for (int i = 1; i < timeSeries.Length; i++) {
            var n = timeSeries[i];
            if (n <= e) {
                e = n + duration;
            } else {
                res += e - s;
                s = n;
                e = n + duration;
            }
        }
        res += e - s;
        return res;
    }
}