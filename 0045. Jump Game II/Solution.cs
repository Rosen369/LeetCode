public class Solution {
    public int Jump (int[] nums) {
        if (nums.Length == 1) {
            return 0;
        }
        var res = nums.Length;
        JumpNext (nums, 0, ref res, 0);
        return res;
    }

    public void JumpNext (int[] nums, int index, ref int res, int steps) {
        if (res <= steps + 1) {
            return;
        }
        if (nums.Length - 1 - index <= nums[index]) {
            res = steps + 1;
            return;
        }
        for (int i = 1; i <= nums[index]; i++) {
            JumpNext (nums, index + i, ref res, steps + 1);
        }
    }
}