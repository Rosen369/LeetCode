public class Solution {
    public IList<IList<int>> FindSubsequences (int[] nums) {
        var set = new HashSet<string> ();
        var res = new List<IList<int>> ();
        this.Combine (res, set, nums, new List<int> (), 0, string.Empty);
        return res;
    }

    private void Combine (List<IList<int>> res, HashSet<string> set, int[] nums, IList<int> combine, int index, string key) {
        for (int i = index; i < nums.Length; i++) {
            if (combine.Count < 1 || nums[i] >= combine[combine.Count - 1]) {
                var next = new List<int> (combine);
                next.Add (nums[i]);
                var nkey = key + '_' + nums[i];
                if (next.Count > 1 && !set.Contains (nkey)) {
                    res.Add (next);
                    set.Add (nkey);
                }
                this.Combine (res, set, nums, next, i + 1, nkey);
            }
        }
    }
}