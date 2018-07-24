public class Solution {
    public IList<IList<int>> PermuteUnique (int[] nums) {
        var res = new Dictionary<string, IList<int>> ();
        AddNext (nums, res, new List<int> (), new List<int> ());
        return res.Values.ToList ();
    }

    public void AddNext (int[] nums, IDictionary<string, IList<int>> res, IList<int> lastList, IList<int> usedIndex) {
        if (lastList.Count () == nums.Length) {
            var key = GetKey (lastList);
            if (!res.ContainsKey (key)) {
                res.Add (key, lastList);
            }
            return;
        }
        for (int i = 0; i < nums.Length; i++) {
            if (!usedIndex.Contains (i)) {
                var currList = new List<int> (lastList);
                currList.Add (nums[i]);
                var currIndex = new List<int> (usedIndex);
                currIndex.Add (i);
                AddNext (nums, res, currList, currIndex);
            }
        }
    }

    public string GetKey (IList<int> lastList) {
        var res = string.Empty;
        for (int i = 0; i < lastList.Count (); i++) {
            res += lastList[i] + '_';
        }
        return res;
    }
}