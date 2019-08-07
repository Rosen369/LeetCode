public class Solution {
    public double[] MedianSlidingWindow (int[] nums, int k) {
        var res = new List<double> ();
        var window = new List<int> ();
        for (int i = 0; i < k - 1; i++) {
            window.Add (nums[i]);
        }
        window = window.OrderBy (e => e).ToList ();
        for (int i = k - 1; i < nums.Length; i++) {
            for (int j = 0; j < k - 1; j++) {
                if (nums[i] <= window[j]) {
                    window.Insert (j, nums[i]);
                    break;
                }
            }
            if (window.Count < k) {
                window.Add (nums[i]);
            }
            if (k % 2 == 0) {
                var mid1 = (k - 1) / 2;
                var mid2 = k / 2;
                var median = window[mid1] / 2d + window[mid2] / 2d;
                res.Add (median);
            } else {
                var mid = (k - 1) / 2;
                res.Add (window[mid]);
            }
            var remove = nums[i - k + 1];
            for (int j = 0; j < window.Count; j++) {
                if (window[j] == remove) {
                    window.RemoveAt (j);
                    break;
                }
            }
        }
        return res.ToArray ();
    }
}