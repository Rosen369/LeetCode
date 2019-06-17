public class Solution {
    public bool Makesquare (int[] nums) {
        if (nums.Length < 4) {
            return false;
        }
        var sum = nums.Sum ();
        if (sum % 4 != 0) return false;
        var target = sum / 4;
        Array.Sort (nums);
        Array.Reverse (nums);
        if (nums[0] > target) {
            return false;
        }
        return DFS (nums, new int[4], target, 0);
    }

    public bool DFS (int[] nums, int[] sums, int target, int index) {
        if (index == nums.Length) {
            for (int i = 0; i < 4; i++) {
                if (sums[i] != target) return false;
            }
            return true;
        }
        for (int i = 0; i < 4; i++) {
            if (sums[i] + nums[index] > target) continue;
            sums[i] += nums[index];
            if (this.DFS (nums, sums, target, index + 1)) return true;
            sums[i] -= nums[index];
        }
        return false;
    }
}