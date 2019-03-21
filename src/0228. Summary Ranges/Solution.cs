public class Solution {
    public IList<string> SummaryRanges (int[] nums) {
        var dict = new Dictionary<int, int> ();
        for (int i = 0; i < nums.Length; i++) {
            var n = nums[i];
            if (dict.ContainsKey (n - 1)) {
                var start = dict[n - 1];
                dict.Remove (n - 1);
                dict.Add (n, start);
            } else {
                dict.Add (n, n);
            }
        }
        var res = new List<string> ();
        foreach (var pair in dict) {
            if (pair.Key == pair.Value) {
                res.Add (pair.Key.ToString ());
            } else {
                res.Add (pair.Value + "->" + pair.Key);
            }
        }
        return res;
    }
}