public class Solution {
    public int ThirdMax (int[] nums) {
        int? max1 = null;
        int? max2 = null;
        int? max3 = null;
        for (int i = 0; i < nums.Length; i++) {
            if (max1 == nums[i] || max2 == nums[i] || max3 == nums[i]) {
                continue;
            }
            if (max1 == null || nums[i] > max1) {
                max3 = max2;
                max2 = max1;
                max1 = nums[i];
            } else if (max2 == null || nums[i] > max2) {
                max3 = max2;
                max2 = nums[i];
            } else if (max3 == null || nums[i] > max3) {
                max3 = nums[i];
            }
        }
        if (max3 == null) {
            return max1.Value;
        }
        return max3.Value;
    }
}