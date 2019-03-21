public class Solution {
    public void ReverseString (char[] s) {
        Recursion (s, 0, s.Length - 1);
    }

    public void Recursion (char[] s, int i, int j) {
        if (i == j || i > j) {
            return;
        }
        Swap (s, i, j);
        Recursion (s, i + 1, j - 1);
    }

    public void Swap (char[] s, int i, int j) {
        var temp = s[i];
        s[i] = s[j];
        s[j] = temp;
    }
}