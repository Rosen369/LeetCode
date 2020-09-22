public class Solution {
    public int LeastBricks (IList<IList<int>> wall) {
        var min = wall.Count;
        var dict = new Dictionary<int, int> ();
        for (int i = 0; i < wall.Count; i++) {
            var row = wall[i];
            var x = 0;
            for (int j = 0; j < row.Count - 1; j++) {
                x += row[j];
                if (!dict.ContainsKey (x)) {
                    dict.Add (x, 0);
                }
                dict[x]++;
            }
        }
        var breaks = dict.Values.ToList ();
        for (int i = 0; i < breaks.Count; i++) {
            min = Math.Min (min, wall.Count - breaks[i]);
        }
        return min;
    }
}