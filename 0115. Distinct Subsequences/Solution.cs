public class Solution {
    public int NumDistinct (string s, string t) {
        if (t.Length == 0) {
            return 1;
        }
        if (t.Length > s.Length) {
            return 0;
        }
        var count = 0;
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == t[0]) {
                count += NumDistinct (s.Substring (i + 1), t.Substring (1));
            }
        }
        return count;
    }
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode (int x) { val = x; }
}