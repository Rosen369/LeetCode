public class Solution {
    public bool Find132pattern (int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            var pre = int.MinValue;
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[j] <= nums[i]) {
                    continue;
                }
                if (nums[j] < pre) {
                    return true;
                }
                pre = nums[j];
            }
        }
        return false;
    }
}