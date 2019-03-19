public class Solution {

    public Solution (int[] nums) {
        this._dict = new Dictionary<int, IList<int>> ();
        this._random = new Random ();
        for (int i = 0; i < nums.Length; i++) {
            if (!_dict.ContainsKey (nums[i])) {
                _dict.Add (nums[i], new List<int> ());
            }
            _dict[nums[i]].Add (i);
        }
    }

    private IDictionary<int, IList<int>> _dict;

    private Random _random;

    public int Pick (int target) {
        var pos = _random.Next (_dict[target].Count);
        return _dict[target][pos];
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int param_1 = obj.Pick(target);
 */