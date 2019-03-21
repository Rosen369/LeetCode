public class Solution {
    public int HIndex (int[] citations) {
        var len = citations.Length;
        var left = 0;
        var right = len - 1;
        while (left <= right) {
            var mid = (left + right) / 2;
            if (citations[mid] == len - mid) {
                return citations[mid];
            } else if (citations[mid] > len - mid) {
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }
        return len - (right + 1);
    }
}