public class Solution {
    public int FindPairs (int[] nums, int k) {
        if (k < 0) {
            return 0;
        }
        var res = 0;
        var dict = new Dictionary<int, int> ();
        for (int i = 0; i < nums.Length; i++) {
            if (dict.ContainsKey (nums[i])) {
                if (k == 0 && dict[nums[i]] == 1) {
                    res++;
                }
                dict[nums[i]]++;
            } else {
                if (dict.ContainsKey (nums[i] + k)) {
                    res++;
                }
                if (dict.ContainsKey (nums[i] - k)) {
                    res++;
                }
                dict.Add (nums[i], 1);
            }
        }
        return res;
    }
}