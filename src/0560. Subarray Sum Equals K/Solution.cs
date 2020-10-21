public class Solution {
    public int SubarraySum (int[] nums, int k) {
        var res = 0;
        var sum = 0;
        var dict = new Dictionary<int, int> ();

        dict[0] = 1;
        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i];
            if (dict.ContainsKey (sum - k)) {
                res += dict[sum - k];
            }
            if (dict.ContainsKey (sum)) {
                dict[sum]++;
            } else {
                dict[sum] = 1;
            }
        }
        return res;
    }
}