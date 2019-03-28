public class Solution {
    public bool CanPartition (int[] nums) {
        var sum = 0;
        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i];
        }
        if (sum % 2 == 1) {
            return false;
        }
        var target = sum / 2;
        return DFS (nums, 0, 0, target);
    }

    private bool DFS (int[] nums, int index, int sum, int target) {
        if (sum == target) {
            return true;
        }
        if (sum > target) {
            return false;
        }
        for (int i = index; i < nums.Length; i++) {
            if (DFS (nums, i + 1, sum + nums[i], target)) {
                return true;
            }
        }
        return false;
    }
}