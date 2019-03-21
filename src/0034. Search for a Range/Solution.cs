public class Solution {
    public int[] SearchRange (int[] nums, int target) {
        var res = new int[] {-1, -1 };
        var left = 0;
        var right = nums.Length;
        while (left < right) {
            var mid = (left + right) / 2;
            if (nums[mid] == target) {
                res[0] = mid;
                right = mid;
            } else if (nums[mid] > target) {
                right = mid;
            } else {
                left = mid + 1;
            }
        }
        if (res[0] == -1) {
            return res;
        }
        left = res[0];
        right = nums.Length;
        while (left < right) {
            var mid = (left + right) / 2;
            if (mid == left) {
                res[1] = mid;
                break;
            }
            if (nums[mid] == target) {
                res[1] = mid;
                left = mid;
            } else if (nums[mid] > target) {
                right = mid;
            } else {
                left = mid + 1;
            }
        }
        return res;
    }
}