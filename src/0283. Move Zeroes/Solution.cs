public class Solution {
    public void MoveZeroes (int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) {
                for (int j = i + 1; j < nums.Length; j++) {
                    if (nums[j] != 0) {
                        nums[i] = nums[j];
                        nums[j] = 0;
                        break;
                    }
                }
            }
        }
    }
}