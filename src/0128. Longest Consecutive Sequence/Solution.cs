public class Solution {
    public int LongestConsecutive (int[] nums) {
        if (nums.Length == 0) {
            return 0;
        }
        var set = new HashSet<int> (nums);
        var longest = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (set.Contains (nums[i] - 1)) {
                continue;
            }
            var num = nums[i];
            var curr = 1;
            while (set.Contains (++num)) {
                curr++;
            }
            longest = Math.Max (curr, longest);
        }
        return longest;
    }
}