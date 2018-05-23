public class Solution {
    public int RemoveDuplicates (int[] nums) {
        if (nums.Length < 2) {
            return nums.Length;
        }
        var len = 0;
        for (var i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[len]) {
                len++;
                nums[len] = nums[i];
            }
        }
        return len + 1;
    }
}