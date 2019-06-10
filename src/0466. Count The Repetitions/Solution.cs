public class Solution {
    public int GetMaxRepetitions (string s1, int n1, string s2, int n2) {
        var kToRepeatCount = new Dictionary<int, int> ();
        var nextIndexToK = new Dictionary<int, int> ();
        kToRepeatCount.Add (0, 0);
        nextIndexToK.Add (0, 0);
        var j = 0;
        var count = 0;
        for (int k = 1; k <= n1; k++) {
            for (int i = 0; i < s1.Length; i++) {
                if (s1[i] == s2[j]) {
                    j++;
                    if (j == s2.Length) {
                        j = 0;
                        count++;
                    }
                }
            }
            if (nextIndexToK.ContainsKey (j)) {
                var start = nextIndexToK[j];
                var prefixCount = kToRepeatCount[start];
                var patternCount = (n1 - start) / (k - start) * (count - prefixCount);
                var suffixCount = kToRepeatCount[start + (n1 - start) % (k - start)] - prefixCount;
                return (prefixCount + patternCount + suffixCount) / n2;
            }
            kToRepeatCount[k] = count;
            nextIndexToK[j] = k;
        }
        return kToRepeatCount[n1] / n2;
    }
}