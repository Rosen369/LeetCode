public class Solution {
    public void NextPermutation (int[] nums) {
        var i = nums.Length - 2;
        while (i >= 0 && nums[i + 1] <= nums[i]) {
            i--;
        }
        if (i >= 0) {
            var j = nums.Length - 1;
            while (j >= 0 && nums[j] <= nums[i]) {
                j--;
            }
            Swap (nums, i, j);
        }
        Reverse (nums, i + 1);
    }

    private void Reverse (int[] nums, int left) {
        var right = nums.Length - 1;
        while (left < right) {
            Swap (nums, left, right);
            left++;
            right--;
        }
    }

    private void Swap (int[] nums, int i, int j) {
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}