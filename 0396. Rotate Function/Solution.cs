public class Solution {
    public int MaxRotateFunction (int[] A) {
        if (A.Length == 0) {
            return 0;
        }
        var max = int.MinValue;
        for (int i = 0; i < A.Length; i++) {
            var curr = 0;
            for (int j = 0; j < A.Length; j++) {
                var pos = (i + j) % A.Length;
                curr += A[pos] * j;
            }
            max = Math.Max (curr, max);
        }
        return max;
    }
}