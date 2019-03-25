public class Solution {
    public int[, ] ReconstructQueue (int[, ] people) {
        var len = people.GetLength (0);
        var list = new List<int[]> ();
        var dict = new Dictionary<int, IList<int>> ();
        for (int i = 0; i < len; i++) {
            var h = people[i, 0];
            var k = people[i, 1];
            if (!dict.ContainsKey (h)) {
                dict.Add (h, new List<int> ());
            }
            dict[h].Add (k);
        }
        var heights = dict.Keys.ToArray ();
        Array.Sort (heights);
        for (int i = heights.Length - 1; i >= 0; i--) {
            var h = heights[i];
            var pos = dict[h].ToArray ();
            Array.Sort (pos);
            for (int j = 0; j < pos.Length; j++) {
                var p = pos[j];
                list.Insert (p, new int[] { h, p });
            }
        }
        var res = new int[len, 2];
        for (int i = 0; i < len; i++) {
            res[i, 0] = list[i][0];
            res[i, 1] = list[i][1];
        }
        return res;
    }
}