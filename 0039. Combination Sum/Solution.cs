public class Solution {
    public IList<IList<int>> CombinationSum (int[] candidates, int target) {
        var res = new List<IList<int>> ();
        SearchNext (res, candidates, target, 0, new List<int> ());
        return res;
    }

    public void SearchNext (IList<IList<int>> res, int[] candidates, int target, int index, IList<int> current) {
        for (int i = index; i < candidates.Length; i++) {
            var combine = new List<int> ();
            combine.AddRange (current.ToArray ());
            combine.Add (candidates[i]);
            var sum = SumList (combine);
            if (sum == target) {
                res.Add (combine);
            } else if (sum < target) {
                SearchNext (res, candidates, target, i, combine);
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