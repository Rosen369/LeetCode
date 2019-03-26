public class Solution {
    public int SplitArray (int[] nums, int m) {
        var max = 0;
        var sum = 0L;
        for (int i = 0; i < nums.Length; i++) {
            max = Math.Max (max, nums[i]);
            sum += nums[i];
        }
        if (m == 1) {
            return (int) sum;
        }
        var l = (long) max;
        var r = sum;
        while (l <= r) {
            var mid = (l + r) / 2;
            if (Valid (mid, nums, m)) {
                r = mid - 1;
            } else {
                l = mid + 1;
            }
        }
        return (int) l;
    }

    private bool Valid (long target, int[] nums, int m) {
        var count = 1;
        var total = 0;
        for (int i = 0; i < nums.Length; i++) {
            total += nums[i];
            if (total > target) {
                total = nums[i];
                count++;
                if (count > m) {
                    return false;
                }
            }
        }
        return true;
    }
}