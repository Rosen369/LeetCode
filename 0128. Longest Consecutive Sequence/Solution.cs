public class Solution {
    public int LongestConsecutive (int[] nums) {
        if (nums.Length == 0) {
            return 0;
        }
        Array.Sort (nums);
        var currLength = 1;
        var longestLength = 1;
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] == nums[i - 1]) {
                continue;
            }
            if (nums[i] == nums[i - 1] + 1) {
                currLength++;
            } else {
                longestLength = Math.Max (longestLength, currLength);
                currLength = 1;
            }
        }
        longestLength = Math.Max (longestLength, currLength);
        return longestLength;
    }
}