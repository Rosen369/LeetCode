public class Solution {
    public int MaxCoins (int[] nums) {
        return Backtracking (new List<int> (nums));
    }

    public int Backtracking (IList<int> nums) {
        if (nums.Count () == 1) {
            return nums[0];
        }
        var max = 0;
        for (int i = 0; i < nums.Count (); i++) {
            var left = 1;
            var right = 1;
            if (i > 0) {
                left = nums[i - 1];
            }
            if (i < nums.Count () - 1) {
                right = nums[i + 1];
            }
            var curr = left * nums[i] * right;
            var next = new List<int> (nums);
            next.RemoveAt (i);
            curr += Backtracking (next);
            max = Math.Max (max, curr);
        }
        return max;
    }
}