public class Solution {
    public int LengthOfLastWord (string s) {
        var array = s.Trim ().Split (' ');
        var last = array[array.Length - 1];
        return last.Length;
    }
}