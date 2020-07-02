public class Solution {
    public int SingleNonDuplicate (int[] nums) {
        var left = 0;
        var right = nums.Length - 1;
        while (left < right) {
            var mid = (left + right) / 2;
            if (mid % 2 == 1) {
                mid--;
            }
            if (nums[mid] != nums[mid + 1]) {
                right = mid;
            } else {
                left = mid + 2;
            }
        }
        return nums[left];
    }
}