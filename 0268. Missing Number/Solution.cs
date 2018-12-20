public class Solution {
    public int MissingNumber (int[] nums) {
        var sum = nums.Length * (nums.Length + 1) / 2;
        for (int i = 0; i < nums.Length; i++) {
            sum -= nums[i];
        }
        return sum;
    }
}