public class Solution {
    public int SingleNumber (int[] nums) {
        Array.Sort (nums);
        for (int i = 2; i < nums.Length; i += 3) {
            if (nums[i - 2] != nums[i]) {
                return nums[i - 2];
            }
        }
        return nums[nums.Length - 1];
    }
}