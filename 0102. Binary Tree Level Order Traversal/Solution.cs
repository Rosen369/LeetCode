/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<IList<int>> LevelOrder (TreeNode root) {
        var res = new List<IList<int>> ();
        var curr = new List<TreeNode> ();
        var next = new List<TreeNode> ();
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
                res.Add (list);
            }
            curr.Clear ();
            curr.AddRange (next);
        }
        return res;
    }
}