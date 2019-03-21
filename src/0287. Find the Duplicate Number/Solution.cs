public class Solution {
    public int FindDuplicate (int[] nums) {
        if (nums.Length == 0) {
            return -1;
        }
        var slow = nums[0];
        var fast = nums[nums[0]];
        while (slow != fast) {
            slow = nums[slow];
            fast = nums[nums[fast]];
        }
        fast = 0;
        while (slow != fast) {
            slow = nums[slow];
            fast = nums[fast];
        }
        return slow;
    }
}