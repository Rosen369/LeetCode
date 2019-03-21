public class Solution {
    public int LengthOfLIS (int[] nums) {
        var dict = new Dictionary<int, int> ();
        var max = 0;
        for (int i = 0; i < nums.Length; i++) {
            var res = DFS (nums, i, dict);
            max = Math.Max (max, res);
        }
        return max;
    }

    public int DFS (int[] nums, int start, IDictionary<int, int> dict) {
        if (dict.ContainsKey (start)) {
            return dict[start];
        }
        if (start == nums.Length - 1) {
            return 1;
        }
        var max = 1;
        for (int i = start + 1; i <= nums.Length - 1; i++) {
            if (nums[start] < nums[i]) {
                var res = DFS (nums, i, dict) + 1;
                max = Math.Max (max, res);
            }
        }
        dict.Add (start, max);
        return max;
    }
}