public class Solution {
    public IList<IList<int>> CombinationSum2 (int[] candidates, int target) {
        var res = new Dictionary<string, IList<int>> ();
        Array.Sort (candidates);
        SearchNext (res, candidates, target, 0, new List<int> ());
        return res.Values.ToList ();
    }

    public void SearchNext (IDictionary<string, IList<int>> res, int[] candidates, int target, int index, IList<int> current) {
        for (int i = index; i < candidates.Length; i++) {
            var combine = new List<int> (current);
            var sum = SumList (combine);
            if (sum == target) {
                var key = string.Join ("_", combine.ToArray ());
                if (!res.ContainsKey (key)) {
                    res.Add (key, combine);
                }
            } else if (sum < target) {
                SearchNext (res, candidates, target, i + 1, combine);
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