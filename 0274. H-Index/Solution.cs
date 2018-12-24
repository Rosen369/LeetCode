public class Solution {
    public int HIndex (int[] citations) {
        var res = 0;
        Array.Sort (citations);
        Array.Reverse (citations);
        for (int i = 0; i < citations.Length; i++) {
            if (citations[i] >= i + 1) {
                res = i + 1;
            } else {
                break;
            }
        }
        return res;
    }
}