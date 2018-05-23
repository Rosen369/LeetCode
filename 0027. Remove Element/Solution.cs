public class Solution {
    public int RemoveElement (int[] nums, int val) {
        var left = 0;
        var right = nums.Length - 1;
        while (left <= right) {
            if (nums[left] == val) {
                if (nums[right] == val) {
                    right--;
                    continue;
                } else {
                    nums[left] = nums[right];
                    right--;
                }
            }
            left++;
        }
        return right + 1;
    }
}