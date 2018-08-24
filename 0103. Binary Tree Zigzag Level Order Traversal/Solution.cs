public class Solution {
    public IList<IList<int>> LevelOrder (TreeNode root) {
        var res = new List<IList<int>> ();
        var curr = new List<TreeNode> ();
        var next = new List<TreeNode> ();
        var index = 0;
        curr.Add (root);
        while (curr.Count () != 0) {
            next.Clear ();
            var list = new List<int> ();
            foreach (var node in curr) {
                if (node != null) {
                    list.Add (node.val);
                    next.Add (node.left);
                    next.Add (node.right);
                }
            }
            if (list.Count () != 0) {
                if (index % 2 == 1) {
                    list.Reverse ();
                }
                res.Add (list);
            }
            curr.Clear ();
            curr.AddRange (next);
            index++;
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