public class Solution {
    public IList<IList<int>> CombinationSum2 (int[] candidates, int target) {
        var res = new List<IList<int>> ();
        Array.Sort (candidates);
        SearchNext (res, candidates, target, 0, new List<int> (), 0);
        return res;
    }

    public void SearchNext (IList<IList<int>> res, int[] candidates, int target, int index, IList<int> current, int sum) {
        for (int i = index; i < candidates.Length; i++) {
            if (i > index && candidates[i] == candidates[i - 1]) continue;
            current.Add (candidates[i]);
            var curr_sum = sum + candidates[i];
            if (curr_sum == target) {
                var combine = new List<int> (current);
                res.Add (combine);
            } else if (curr_sum < target) {
                SearchNext (res, candidates, target, i + 1, current, curr_sum);
            }
            current.RemoveAt (current.Count () - 1);
        }
    }
}