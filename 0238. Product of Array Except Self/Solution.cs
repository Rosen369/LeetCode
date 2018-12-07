public class Solution {
    public int[] ProductExceptSelf (int[] nums) {
        var res = new int[nums.Length];
        // using res to cache all product from left
        res[0] = 1;
        for (int i = 1; i < nums.Length; i++) {
            res[i] = res[i - 1] * nums[i - 1];
        }
        var right = 1;
        // res[i] = left product multiply right product
        for (int i = nums.Length - 1; i >= 0; i--) {
            res[i] *= right;
            right *= nums[i];
        }
        return res;
    }
}