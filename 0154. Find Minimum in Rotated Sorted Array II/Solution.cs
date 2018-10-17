public class Solution {
    public int FindMin (int[] nums) {
        var left = 0;
        var right = nums.Length - 1;
        while (left < right) {
            if (nums[left] == nums[left + 1]) {
                left++;
                continue;
            }
            if (nums[right] == nums[right - 1]) {
                right--;
                continue;
            }
            var mid = (left + right) / 2;
            if (nums[mid] < nums[right]) {
                right = mid;
            } else {
                left = mid;
            }
            if (left + 1 == right) {
                return Math.Min (nums[left], nums[right]);
            }
        }
        return nums[left];
    }
}