public class Solution {
    //math solution
    // add to x with m moves
    // sum + m * (n - 1) = x * n
    // x = minNum + m
    // sum - minNum * n = m
    public int MinMoves (int[] nums) {
        var min = int.MaxValue;
        var sum = 0;
        for (int i = 0; i < nums.Length; i++) {
            min = Math.Min (min, nums[i]);
            sum += nums[i];
        }
        var res = sum - min * nums.Length;
        return res;
    }
}