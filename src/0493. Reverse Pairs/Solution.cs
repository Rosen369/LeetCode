public class Solution {
    public int ReversePairs (int[] nums) {
        var buffer = new int[nums.Length];
        return this.MergeCount (nums, 0, nums.Length - 1, buffer);
    }

    private int MergeCount (int[] nums, int start, int end, int[] buffer) {
        if (start >= end) return 0;
        var mid = start + (end - start) / 2;
        var count = this.MergeCount (nums, start, mid, buffer) + this.MergeCount (nums, mid + 1, end, buffer);
        for (int i = start, j = mid + 1; i <= mid; i++) {
            while (j <= end && nums[i] / 2.0 > nums[j]) j++;
            count += j - (mid + 1);
        }
        this.MergeSort (nums, start, mid, end, buffer);
        return count;
    }

    private void MergeSort (int[] nums, int start, int mid, int end, int[] buffer) {
        for (int i = start; i <= end; i++) {
            buffer[i] = nums[i];
        }
        var left = start;
        var right = mid + 1;
        var index = start;
        while (left <= mid || right <= end) {
            if (left > mid) {
                nums[index] = buffer[right++];
            } else if (right > end) {
                nums[index] = buffer[left++];
            } else {
                if (buffer[left] < buffer[right]) {
                    nums[index] = buffer[left++];
                } else {
                    nums[index] = buffer[right++];
                }
            }
            index++;
        }
    }
}