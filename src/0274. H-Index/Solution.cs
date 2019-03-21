public class Solution {
    public int HIndex (int[] citations) {
        var n = citations.Length;
        var buckets = new int[n + 1];
        foreach (var c in citations) {
            if (c >= n) {
                buckets[n]++;
            } else {
                buckets[c]++;
            }
        }
        int count = 0;
        for (int i = n; i >= 0; i--) {
            count += buckets[i];
            if (count >= i) {
                return i;
            }
        }
        return 0;
    }
}