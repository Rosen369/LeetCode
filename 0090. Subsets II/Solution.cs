public class Solution {
    public IList<IList<int>> SubsetsWithDup (int[] nums) {
        Array.Sort (nums);
        var res = new List<IList<int>> ();
        AddNext (res, new List<int> (), nums, 0);
        return res;
    }

    public void AddNext (IList<IList<int>> res, IList<int> curr, int[] nums, int pos) {
        res.Add (new List<int> (curr));
        for (int i = pos; i < nums.Length; i++) {
            if (i == pos || nums[i] != nums[i - 1]) {
                curr.Add (nums[i]);
                AddNext (res, curr, nums, i + 1);
                curr.RemoveAt (curr.Count () - 1);
            }
        }
    }
}