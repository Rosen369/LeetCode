public class Solution {
    public int MaxProduct (int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }
        var preMax = nums[0];
        var preMin = nums[0];
        var currMax = nums[0];
        var currMin = nums[0];
        var res = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            currMax = Math.Max (Math.Max (preMax * nums[i], preMin * nums[i]), nums[i]);
            currMin = Math.Min (Math.Min (preMax * nums[i], preMin * nums[i]), nums[i]);
            res = Math.Max (res, currMax);
            preMax = currMax;
            preMin = currMin;
        }
        return res;
    }
}