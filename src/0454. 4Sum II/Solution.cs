public class Solution {
    public int FourSumCount (int[] A, int[] B, int[] C, int[] D) {
        var count = 0;
        var dict = new Dictionary<int, int> ();
        for (int i = 0; i < A.Length; i++) {
            for (int j = 0; j < B.Length; j++) {
                var target = A[i] + B[j];
                if (!dict.ContainsKey (target)) {
                    dict.Add (target, 0);
                }
                dict[target]++;
            }
        }
        for (int i = 0; i < C.Length; i++) {
            for (int j = 0; j < D.Length; j++) {
                var target = 0 - C[i] - D[j];
                if (dict.ContainsKey (target)) {
                    count += dict[target];
                }
            }
        }
        return count;
    }
}