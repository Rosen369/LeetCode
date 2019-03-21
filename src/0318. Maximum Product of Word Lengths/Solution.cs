public class Solution {
    public int MaxProduct (string[] words) {
        int len = words.Length;
        int[] values = new int[len];
        for (int i = 0; i < len; i++) {
            foreach (var c in words[i]) {
                values[i] |= (1 << (c - 'a'));
            }
        }
        int max = 0;
        for (int i = 0; i < len - 1; i++) {
            for (int j = i + 1; j < len; j++) {
                if ((values[i] & values[j]) == 0) {
                    max = Math.Max (words[i].Length * words[j].Length, max);
                }
            }
        }
        return max;
    }
}