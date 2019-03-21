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
    public IList<int> RightSideView (TreeNode root) {
        if (root == null) {
            return new List<int> ();
        }
        var curr = new List<TreeNode> ();
        var next = new List<TreeNode> ();
        var res = new List<int> ();
        curr.Add (root);
        while (curr.Count () != 0) {
            foreach (var node in curr) {
                if (node.left != null) {
                    next.Add (node.left);
                }
                if (node.right != null) {
                    next.Add (node.right);
                }
            }
            res.Add (curr.Last ().val);
            curr = next;
            next = new List<TreeNode> ();
        }
        return res;
    }
}