public class Solution {
    public IList<int[]> GetSkyline (int[, ] buildings) {
        var buildingsCount = buildings.GetLength (0);
        if (buildingsCount == 0) {
            return new List<int[]> ();
        }
        var dict = new Dictionary<int, int> ();
        for (int i = 0; i < buildingsCount; i++) {
            var x1 = buildings[i, 0];
            var x2 = buildings[i, 1];
            var y = buildings[i, 2];
            for (int x = x1; x <= x2; x++) {
                if (dict.ContainsKey (x)) {
                    dict[x] = Math.Max (dict[x], y);
                } else {
                    dict.Add (x, y);
                }
                if (!dict.ContainsKey (x + 1)) {
                    dict.Add (x + 1, 0);
                }
            }
        }
        var xArray = dict.Keys.ToArray ();
        Array.Sort (xArray);
        var res = new List<int[]> ();
        for (int i = 0; i < xArray.Length; i++) {
            var x = xArray[i];
            if (res.Count () == 0 && dict[x] == 0) {
                continue;
            }
            if (res.Count () == 0 && dict[x] != 0) {
                res.Add (new int[] { x, dict[x] });
                continue;
            }
            if (dict[x] != res[res.Count () - 1][1]) {
                if (dict[x] > res[res.Count () - 1][1]) {
                    res.Add (new int[] { x, dict[x] });
                } else {
                    res.Add (new int[] { x - 1, dict[x] });
                }
            }
        }
        return res;
    }
}