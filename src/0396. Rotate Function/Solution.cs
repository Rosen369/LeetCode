public class Solution {
    public int MaxRotateFunction (int[] A) {
        int n = A.Length;
        int sum = 0;
        int candidate = 0;

        for (int i = 0; i < n; i++) {
            sum += A[i];
            candidate += A[i] * i;
        }
        var max = candidate;

        for (int i = n - 1; i > 0; i--) {
            candidate = candidate + sum - A[i] * n;
            max = Math.Max (max, candidate);
        }
        return max;
    }
}