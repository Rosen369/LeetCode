public class Solution {
    public int ReversePairs (int[] nums) {
        return this.MergeCount (nums, 0, nums.Length - 1);
    }

    private int MergeCount (int[] nums, int start, int end) {
        if (start >= end) return 0;
        var mid = start + (end - start) / 2;
        var count = this.MergeCount (nums, start, mid) + this.MergeCount (nums, mid + 1, end);
        for (int i = start, j = mid + 1; i <= mid; i++) {
            while (j <= end && nums[i] / 2.0 > nums[j]) j++;
            count += j - (mid + 1);
        }
        this.MergeSort (nums, start, mid, end);
        return count;
    }

    private void MergeSort (int[] nums, int start, int mid, int end) {
        var temp = new int[nums.Length];
        for (int i = start; i <= end; i++) {
            temp[i] = nums[i];
        }
        var left = start;
        var right = mid + 1;
        var index = start;
        while (left <= mid || right <= end) {
            if (left > mid) {
                nums[index] = temp[right++];
            } else if (right > end) {
                nums[index] = temp[left++];
            } else {
                if (temp[left] < temp[right]) {
                    nums[index] = temp[left++];
                } else {
                    nums[index] = temp[right++];
                }
            }
            index++;
        }
    }
}