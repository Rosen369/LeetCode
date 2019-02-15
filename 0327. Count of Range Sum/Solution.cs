public class Solution {
    public int CountRangeSum (int[] nums, int lower, int upper) {
        var n = nums.Length;
        var sums = new long[n + 1];
        for (int i = 0; i < n; i++) {
            sums[i + 1] = sums[i] + nums[i];
        }
        return CountWhileMerge (sums, 0, n + 1, lower, upper);
    }

    public int CountWhileMerge (long[] sums, int start, int end, int lower, int upper) {
        if (end - start <= 1) {
            return 0;
        }
        var mid = (start + end) / 2;
        var count = CountWhileMerge (sums, start, mid, lower, upper) + CountWhileMerge (sums, mid, end, lower, upper);
        var j = mid;
        var k = mid;
        var t = mid;
        var cache = new long[end - start];
        for (int i = start, r = 0; i < mid; i++, r++) {
            while (k < end && sums[k] - sums[i] < lower) {
                k++;
            }
            while (j < end && sums[j] - sums[i] <= upper) {
                j++;
            }
            while (t < end && sums[t] < sums[i]) {
                cache[r++] = sums[t++];
            }
            cache[r] = sums[i];
            count += j - k;
        }
        for (int i = 0, n = start; i < t - start; i++, n++) {
            sums[n] = cache[i];
        }
        return count;
    }
}