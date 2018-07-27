public class Solution {
    public bool CanJump (int[] nums) {
        if (nums.Length <= 1) {
            return true;
        }
        var blocked = new bool[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            blocked[i] = false;
        }
        var res = JumpNext (0, nums, blocked);
        return res;
    }

    public bool JumpNext (int index, int[] nums, bool[] blocked) {
        for (int i = nums[index]; i > 0; i--) {
            if (i + index >= nums.Length - 1) {
                return true;
            }
            if (blocked[i + index] == true) {
                continue;
            }
            var res = JumpNext (i + index, nums, blocked);
            if (res == true) {
                return true;
            }
        }
        blocked[index] = true;
        return false;
    }
}