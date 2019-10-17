public class Solution {
    public string[] FindWords (string[] words) {
        var row1 = new HashSet<char> () { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P' };
        var row2 = new HashSet<char> () { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L' };
        var row3 = new HashSet<char> () { 'z', 'x', 'c', 'v', 'b', 'n', 'm', 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };
        var res = new List<string> ();
        for (int i = 0; i < words.Length; i++) {
            var w = words[i];
            HashSet<char> set = null;
            var c0 = w[0];
            if (row1.Contains (c0)) { set = row1; }
            if (row2.Contains (c0)) { set = row2; }
            if (row3.Contains (c0)) { set = row3; }
            if (set == null) { continue; }
            var inRow = true;
            for (int j = 1; j < w.Length; j++) {
                var c = w[j];
                if (!set.Contains (c)) {
                    inRow = false;
                    break;
                }
            }
            if (inRow) { res.Add (w); }
        }
        return res.ToArray ();
    }
}