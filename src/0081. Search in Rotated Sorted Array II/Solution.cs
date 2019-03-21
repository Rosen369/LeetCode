public class Solution {
    public int Search (int[] nums, int target) {
        if (nums == null || nums.Length == 0) {
            return false;
        }
        var start = 0;
        var end = nums.Length - 1;
        while (start <= end) {
            var mid = (start + end) / 2;
            if (target == nums[mid]) {
                return true;
            }
            if (nums[start] < nums[mid]) {
                if (target < nums[start] || target > nums[mid]) {
                    start = mid + 1;
                } else {
                    end = mid - 1;
                }
            } else if (nums[start] > nums[mid]) {
                if (target < nums[mid] || target > nums[end]) {
                    end = mid - 1;
                } else {
                    start = mid + 1;
                }
            } else {
                start++;
            }
        }
        return false;
    }
}