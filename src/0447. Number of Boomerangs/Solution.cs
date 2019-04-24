public class Solution {
    public int NumberOfBoomerangs (int[][] points) {
        var res = 0;
        var len = points.Length;
        for (int i = 0; i < len; i++) {
            var dict = new Dictionary<int, int> ();
            for (int j = 0; j < len; j++) {
                if (i == j) {
                    continue;
                }
                var dx = points[i][0] - points[j][0];
                var dy = points[i][1] - points[j][1];
                var distence = dx * dx + dy * dy;
                if (!dict.ContainsKey (distence)) {
                    dict.Add (distence, 0);
                }
                dict[distence]++;
            }
            var values = dict.Values.ToList ();
            for (int j = 0; j < values.Count; j++) {
                if (values[j] > 1) {
                    res += values[j] * (values[j] - 1);
                }
            }
        }
        return res;
    }
}