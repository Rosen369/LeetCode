public class Solution {
    public int ThreeSumClosest (int[] nums, int target) {
        var result = nums[0] + nums[1] + nums[2];
        Array.Sort (nums);
        for (int i = 0; i < nums.Length; i++) {
            if (i > 0 && nums[i - 1] == nums[i]) {
                continue;
            }
            var left = i + 1;
            var right = nums.Length - 1;
            while (left < right) {
                var sum = nums[i] + nums[left] + nums[right];
                if (Math.Abs (sum - target) < Math.Abs (result - target)) {
                    result = sum;
                }
                if (target > sum) {
                    left++;
                } else {
                    right--;
                }
            }
        }
        return result;
    }
}