public class Solution {
    public int MaxDepth (TreeNode root) {
        var res = 0;
        var curr = new List<TreeNode> ();
        var next = new List<TreeNode> ();
        curr.Add (root);
        while (curr.Count () != 0) {
            next.Clear ();
            var hasValue = false;
            foreach (var node in curr) {
                if (node != null) {
                    hasValue = true;
                    next.Add (node.left);
                    next.Add (node.right);
                }
            }
            if (hasValue) {
                res++;
            }
            curr.Clear ();
            curr.AddRange (next);
        }
        return res;
    }
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode (int x) { val = x; }
}