public class Solution {
    public IList<IList<int>> Permute (int[] nums) {
        var res = new List<IList<int>> ();
        AddNext (nums, res, new List<int> ());
        return res;
    }

    public void AddNext (int[] nums, IList<IList<int>> res, IList<int> lastList) {
        if (lastList.Count () == nums.Length) {
            res.Add (lastList);
            return;
        }
        for (int i = 0; i < nums.Length; i++) {
            if (!lastList.Contains (nums[i])) {
                var currList = new List<int> (lastList);
                currList.Add (nums[i]);
                AddNext (nums, res, currList);
            }
        }
    }
}