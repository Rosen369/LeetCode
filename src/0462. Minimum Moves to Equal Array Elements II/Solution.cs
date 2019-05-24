public class Solution {
    public int MinMoves2 (int[] nums) {
        Array.Sort (nums);
        var median = nums[nums.Length / 2];
        var res = 0;
        for (int i = 0; i < nums.Length; i++) {
            res += Math.Abs (nums[i] - median);
        }
        return res;
    }
}