public class Solution {
    public IList<IList<int>> Subsets (int[] nums) {
        var res = new List<IList<int>> ();
        AddNext (0, nums, res, new List<int> ());
        return res;
    }
    public void AddNext (int index, int[] nums, IList<IList<int>> res, IList<int> curr) {
        res.Add (curr);
        for (int i = index; i < nums.Length; i++) {
            var next = new List<int> (curr);
            next.Add (nums[i]);
            AddNext (i + 1, nums, res, next);
        }
    }
}