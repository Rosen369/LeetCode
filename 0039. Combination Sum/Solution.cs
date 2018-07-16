public class Solution {
    public IList<IList<int>> CombinationSum (int[] candidates, int target) {
        var res = new Dictionary<string, IList<int>> ();
        BackTrack (res, candidates, target, new List<int> ());
        return res.Values.ToList ();
    }

    public void BackTrack (IDictionary<string, IList<int>> res, int[] candidates, int target, IList<int> current) {
        for (int i = 0; i < candidates.Length; i++) {
            var combine = new List<int> ();
            combine.AddRange (current.ToArray ());
            combine.Add (candidates[i]);
            var sum = SumList (combine);
            if (sum == target) {
                combine.Sort ();
                var key = string.Join ("_", combine.ToArray ());
                if (!res.ContainsKey (key)) {
                    res.Add (key, combine);
                }
            } else if (sum < target) {
                BackTrack (res, candidates, target, combine);
            }
        }
    }

    public int SumList (IList<int> list) {
        var res = 0;
        foreach (var item in list) {
            res += item;
        }
        return res;
    }
}