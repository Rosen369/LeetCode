public class Solution {
    public int Search (int[] nums, int target) {
        var low = 0;
        var high = nums.Length;
        while (low < high) {
            var mid = (low + high) / 2;
            var num = nums[mid];
            if (nums[mid] < nums[0] != target < nums[0]) {
                if (target < nums[0]) {
                    num = int.MinValue;
                } else {
                    num = int.MaxValue;
                }
            }
            if (num < target) {
                low = mid + 1;
            } else if (num > target) {
                high = mid;
            } else {
                return mid;
            }
        }
        return -1;
    }
}