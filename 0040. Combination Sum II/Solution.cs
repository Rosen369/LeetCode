public class Solution {
    public IList<IList<int>> CombinationSum2 (int[] candidates, int target) {
        var res = new Dictionary<string, IList<int>> ();
        Array.Sort (candidates);
        SearchNext (res, candidates, target, 0, new List<int> (), 0);
        return res.Values.ToList ();
    }

    public void SearchNext (IDictionary<string, IList<int>> res, int[] candidates, int target, int index, IList<int> current, int sum) {
        for (int i = index; i < candidates.Length; i++) {
            var combine = new List<int> (current);
            combine.Add (candidates[i]);
            var curr_sum = sum + candidates[i];
            if (curr_sum == target) {
                var key = string.Join ("_", combine.ToArray ());
                if (!res.ContainsKey (key)) {
                    res.Add (key, combine);
                }
            } else if (curr_sum < target) {
                SearchNext (res, candidates, target, i + 1, combine, curr_sum);
            }
        }
    }
}