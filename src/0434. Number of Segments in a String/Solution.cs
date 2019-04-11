public class Solution {
    public int CountSegments (string s) {
        var splits = s.Split (' ');
        var count = 0;
        for (int i = 0; i < splits.Length; i++) {
            if (!string.IsNullOrEmpty (splits[i])) {
                count++;
            }
        }
        return count;
    }
}