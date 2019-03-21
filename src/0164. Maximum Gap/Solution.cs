public class Solution {
    public int MaximumGap (int[] nums) {
        if (nums.Length < 2) {
            return 0;
        }
        nums = RadixSort (nums);
        var gap = nums[1] - nums[0];
        for (int i = 2; i < nums.Length; i++) {
            gap = Math.Max (gap, nums[i] - nums[i - 1]);
        }
        return gap;
    }

    public int[] RadixSort (int[] nums) {
        var max = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            max = Math.Max (max, nums[i]);
        }
        for (int exp = 1; max / exp > 0; exp *= 10) {
            var buckets = ListToBuckets (nums, exp);
            nums = BucketsToList (nums, buckets);
        }
        return nums;
    }

    private int[] BucketsToList (int[] nums, IList<IList<int>> buckets) {
        var list = new List<int> ();
        foreach (var bucket in buckets) {
            foreach (var num in bucket) {
                list.Add (num);
            }
        }
        return list.ToArray ();
    }

    private IList<IList<int>> ListToBuckets (int[] nums, int exp) {
        var buckets = new List<IList<int>> ();
        for (int i = 0; i < 10; i++) {
            buckets.Add (new List<int> ());
        }
        for (int i = 0; i < nums.Length; i++) {
            buckets[nums[i] / exp % 10].Add (nums[i]);
        }
        return buckets;
    }
}