public class Solution {
    public string ReverseWords (string s) {
        var arr = s.Split (' ');
        var sb = new StringBuilder ();
        for (int i = arr.Length - 1; i >= 0; i--) {
            if (!string.IsNullOrEmpty (arr[i])) {
                sb.Append (arr[i].Trim ());
                sb.Append (" ");
            }
        }
        return sb.ToString ().TrimEnd ();
    }
}