public class Solution {
    public int MaxSumSubmatrix (int[, ] matrix, int k) {
        var m = matrix.GetLength (0);
        var n = matrix.GetLength (1);
        var res = int.MinValue;
        var sum = new long[m + 1]; // stores sum of rect[0..p][i..j]
        for (int i = 0; i < n; ++i) {
            var sumInRow = new long[m];
            for (int j = i; j < n; ++j) { // for each rect[*][i..j]
                for (int p = 0; p < m; ++p) {
                    sumInRow[p] += matrix[p, j];
                    sum[p + 1] = sum[p] + sumInRow[p];
                }
                res = Math.Max (res, MergeSort (sum, 0, m + 1, k));
                if (res == k) return k;
            }
        }
        return res;
    }

    private int MergeSort (long[] sum, int start, int end, int k) {
        if (end == start + 1) {
            return int.MinValue; // need at least 2 to proceed
        }
        var mid = start + (end - start) / 2;
        var count = 0;
        var res = MergeSort (sum, start, mid, k);
        if (res == k) return k;
        res = Math.Max (res, MergeSort (sum, mid, end, k));
        if (res == k) return k;
        var cache = new long[end - start];
        for (int i = start, j = mid, p = mid; i < mid; ++i) {
            while (j < end && sum[j] - sum[i] <= k) ++j;
            if (j - 1 >= mid) {
                res = Math.Max (res, (int) (sum[j - 1] - sum[i]));
                if (res == k) return k;
            }
            while (p < end && sum[p] < sum[i]) cache[count++] = sum[p++];
            cache[count++] = sum[i];
        }
        Array.Copy (cache, 0, sum, start, count);
        return res;
    }
}