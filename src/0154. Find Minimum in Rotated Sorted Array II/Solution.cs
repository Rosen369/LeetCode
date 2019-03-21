public class Solution {
    public int FindMin (int[] nums) {
        var left = 0;
        var right = nums.Length - 1;
        while (left < right) {
            var mid = (left + right) / 2;
            if (nums[mid] < nums[right]) {
                right = mid;
            } else if (nums[mid] > nums[right]) {
                left = mid + 1;
            } else {
                right--;
            }
        }
        return nums[left];
    }
}