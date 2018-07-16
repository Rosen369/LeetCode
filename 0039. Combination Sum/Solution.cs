public class Solution {
    public IList<IList<int>> CombinationSum (int[] candidates, int target) {
        var res = new List<IList<int>> ();
        SearchNext (res, candidates, target, 0, new List<int> (), 0);
        return res;
    }

    public void SearchNext (IList<IList<int>> res, int[] candidates, int target, int index, IList<int> current, int sum) {
        for (int i = index; i < candidates.Length; i++) {
            var combine = new List<int> (current);
            combine.Add (candidates[i]);
            var curr_sum = sum + candidates[i];
            if (curr_sum == target) {
                res.Add (combine);
            } else if (curr_sum < target) {
                SearchNext (res, candidates, target, i, combine, curr_sum);
            }
        }
    }
}