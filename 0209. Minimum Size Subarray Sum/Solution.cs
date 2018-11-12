public class Solution {
    public int MinSubArrayLen (int s, int[] nums) {
        if (nums.Length == 0) {
            return 0;
        }
        var min = nums.Length + 1;
        var sum = nums[0];
        var left = 0;
        var right = 0;
        while (left <= right) {
            if (sum >= s) {
                min = Math.Min (min, right - left + 1);
                sum -= nums[left];
                left++;
            } else {
                right++;
                if (right >= nums.Length) {
                    break;
                }
                sum += nums[right];
            }
        }
        if (min == nums.Length + 1) {
            return 0;
        }
        return min;
    }
}