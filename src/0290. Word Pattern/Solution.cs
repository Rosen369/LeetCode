public class Solution {
    public bool WordPattern (string pattern, string str) {
        var set = new HashSet<string> ();
        var dict = new Dictionary<char, string> ();
        var arr = str.Split (' ');
        if (pattern.Length != arr.Length) {
            return false;
        }
        for (int i = 0; i < pattern.Length; i++) {
            if (dict.ContainsKey (pattern[i])) {
                if (arr[i] != dict[pattern[i]]) {
                    return false;
                }
            } else {
                if (set.Contains (arr[i])) {
                    return false;
                } else {
                    dict.Add (pattern[i], arr[i]);
                    set.Add (arr[i]);
                }
            }
        }
        return true;
    }
}