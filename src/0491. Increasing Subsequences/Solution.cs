public class Solution {
    public IList<IList<int>> FindSubsequences (int[] nums) {
        var set = new HashSet<string> ();
        var res = new List<IList<int>> ();
        for (int i = 0; i < nums.Length; i++) {
            var combine = new List<int> ();
            combine.Add (nums[i]);
            this.Combine (res, set, nums, combine, i + 1, nums[i].ToString ());
        }
        return res;
    }

    private void Combine (List<IList<int>> res, HashSet<string> set, int[] nums, IList<int> combine, int index, string key) {
        for (int i = index; i < nums.Length; i++) {
            if (nums[i] >= combine[combine.Count - 1]) {
                var next = new List<int> (combine);
                next.Add (nums[i]);
                var nKey = key + '_' + nums[i];
                if (!set.Contains (nKey)) {
                    res.Add (next);
                    set.Add (nKey);
                }
                this.Combine (res, set, nums, next, i + 1, nKey);
            }
        }
    }
}