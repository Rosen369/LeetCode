public class Solution {
    public int FindLUSlength (string a, string b) {
        if (a.Equals (b)) {
            return -1;
        }
        return Math.Max (a.Length, b.Length);
    }
}