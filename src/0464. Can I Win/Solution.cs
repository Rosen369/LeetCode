public class Solution {
    public bool CanIWin (int maxChoosableInteger, int desiredTotal) {
        if (desiredTotal <= maxChoosableInteger) return true;
        if (((1 + maxChoosableInteger) / 2 * maxChoosableInteger) < desiredTotal) return false;
        var dict = new Dictionary<string, bool> ();
        var used = new bool[maxChoosableInteger + 1];
        return DFS (desiredTotal, dict, used);
    }

    private bool DFS (int desiredTotal, IDictionary<string, bool> dict, bool[] used) {
        if (desiredTotal <= 0) return false;
        var key = GetKey (used);
        if (dict.ContainsKey (key)) return dict[key];
        for (int i = 1; i < used.Length; i++) {
            if (used[i]) continue;
            var left = desiredTotal - i;
            used[i] = true;
            var next = DFS (left, dict, used);
            used[i] = false;
            if (!next) {
                dict.Add (key, true);
                return true;
            }
        }
        dict.Add (key, false);
        return false;
    }

    private string GetKey (bool[] used) {
        var res = new StringBuilder ();
        for (int i = 1; i < used.Length; i++) {
            if (used[i]) {
                res.Append (i).Append ('_');
            }
        }
        return res.ToString ();
    }
}