public class Solution {
    public int MajorityElement (int[] nums) {
        var dict = new Dictionary<int, int> ();
        var half = nums.Length / 2;
        for (int i = 0; i < nums.Length; i++) {
            if (dict.ContainsKey (nums[i])) {
                dict[nums[i]]++;
            } else {
                dict.Add (nums[i], 1);
            }
            if (dict[nums[i]] > half) {
                return nums[i];
            }
        }
        return 0;
    }
}