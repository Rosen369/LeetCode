public class Solution {
    public int NumberOfArithmeticSlices (int[] A) {
        var res = 0;
        var dp = new IDictionary<int, int>[A.Length];
        for (int i = 0; i < A.Length; i++) {
            dp[i] = new Dictionary<int, int> ();
            for (int j = 0; j < i; j++) {
                var diff = (long) A[i] - (long) A[j];
                if (diff > int.MaxValue || diff < int.MinValue) {
                    continue;
                }
                var d = (int) diff;
                var c1 = dp[i].ContainsKey (d) ? dp[i][d] : 0;
                var c2 = dp[j].ContainsKey (d) ? dp[j][d] : 0;
                res += c2;
                dp[i][d] = c1 + c2 + 1;
            }
        }
        return res;
    }
}