public class Solution {
    public int Rob (int[] nums) {
        if (nums.Length == 0) {
            return 0;
        }
        return Recursive (nums, 0);
    }

    public int Recursive (int[] nums, int start) {
        if (start >= nums.Length) {
            return 0;
        }
        if (nums.Length == start + 1) {
            return nums[start];
        }
        var first = nums[start] + Recursive (nums, start + 2);
        var second = nums[start + 1] + Recursive (nums, start + 3);
        return Math.Max (first, second);
    }
}