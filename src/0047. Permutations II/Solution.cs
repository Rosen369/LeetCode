public class Solution {
    public IList<IList<int>> PermuteUnique (int[] nums) {
        var res = new List<IList<int>> ();
        Array.Sort (nums);
        AddNext (nums, res, new List<int> (), new List<int> ());
        return res;
    }

    public void AddNext (int[] nums, IList<IList<int>> res, IList<int> lastList, IList<int> usedIndex) {
        if (lastList.Count () == nums.Length) {
            res.Add (lastList);
            return;
        }
        for (int i = 0; i < nums.Length; i++) {
            if (i > 0 && nums[i - 1] == nums[i] && usedIndex.Contains (i - 1)) {
                continue;
            }
            if (usedIndex.Contains (i)) {
                continue;
            }
            var currList = new List<int> (lastList);
            currList.Add (nums[i]);
            var currIndex = new List<int> (usedIndex);
            currIndex.Add (i);
            AddNext (nums, res, currList, currIndex);
        }
    }
}