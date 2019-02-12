public class Solution {
    public int[] MaxNumber (int[] nums1, int[] nums2, int k) {
        var res = new int[k];
        var n = nums1.Length;
        var m = nums2.Length;
        for (var i = Math.Max (0, k - m); i <= k && i <= n; i++) {
            var left = MaxK (nums1, i);
            var right = MaxK (nums2, k - i);
            var merged = Merge (left, right, k);
            if (Greater (merged, res, 0, 0)) {
                res = merged;
            }
        }
        return res;
    }

    public int[] MaxK (int[] nums, int k) {
        int n = nums.Length;
        int[] res = new int[k];
        for (int i = 0, j = 0; i < n; i++) {
            while (n - i + j > k && j > 0 && res[j - 1] < nums[i]) {
                j--;
            }
            if (j < k) {
                res[j++] = nums[i];
            }
        }
        return res;
    }

    public int[] Merge (int[] nums1, int[] nums2, int k) {
        int[] ans = new int[k];
        for (int i = 0, j = 0, r = 0; r < k; r++) {
            if (Greater (nums1, nums2, i, j)) {
                ans[r] = nums1[i++];
            } else {
                ans[r] = nums2[j++];
            }
        }
        return ans;
    }

    public bool Greater (int[] nums1, int[] nums2, int i, int j) {
        while (i < nums1.Length && j < nums2.Length && nums1[i] == nums2[j]) {
            i++;
            j++;
        }
        return nums2.Length == j || (i < nums1.Length && nums1[i] > nums2[j]);
    }
}