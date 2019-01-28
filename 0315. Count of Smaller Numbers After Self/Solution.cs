public class Solution {
    public IList<int> CountSmaller (int[] nums) {
        var res = new List<int> ();
        var count = new int[nums.Length];
        var indexes = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            indexes[i] = i;
        }
        MergeSort (nums, indexes, 0, nums.Length - 1, count);
        for (int i = 0; i < count.Length; i++) {
            res.Add (count[i]);
        }
        return res;
    }

    private void MergeSort (int[] nums, int[] indexes, int start, int end, int[] count) {
        if (end <= start) {
            return;
        }
        var mid = (start + end) / 2;
        MergeSort (nums, indexes, start, mid, count);
        MergeSort (nums, indexes, mid + 1, end, count);

        Merge (nums, indexes, start, end, count);
    }
    private void Merge (int[] nums, int[] indexes, int start, int end, int[] count) {
        var mid = (start + end) / 2;
        var leftIndex = start;
        var rightIndex = mid + 1;
        var rightCount = 0;
        var newIndexes = new int[end - start + 1];

        var sort_index = 0;
        while (leftIndex <= mid && rightIndex <= end) {
            if (nums[indexes[rightIndex]] < nums[indexes[leftIndex]]) {
                newIndexes[sort_index] = indexes[rightIndex];
                rightCount++;
                rightIndex++;
            } else {
                newIndexes[sort_index] = indexes[leftIndex];
                count[indexes[leftIndex]] += rightCount;
                leftIndex++;
            }
            sort_index++;
        }
        while (leftIndex <= mid) {
            newIndexes[sort_index] = indexes[leftIndex];
            count[indexes[leftIndex]] += rightCount;
            leftIndex++;
            sort_index++;
        }
        while (rightIndex <= end) {
            newIndexes[sort_index++] = indexes[rightIndex++];
        }
        for (int i = start; i <= end; i++) {
            indexes[i] = newIndexes[i - start];
        }
    }
}