public class Solution {
    public int FindMaxConsecutiveOnes (int[] nums) {
        var max = 0;
        var curr = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 1) {
                curr++;
                max = Math.Max (curr, max);
            } else {
                curr = 0;
                continue;
            }
        }
        return max;
    }
}