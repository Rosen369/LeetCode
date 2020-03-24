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
    public IList<int> LargestValues (TreeNode root) {
        var res = new List<int> ();
        if (root == null) {
            return res;
        }
        var row = new List<TreeNode> ();
        row.Add (root);
        while (row.Count != 0) {
            var max = int.MinValue;
            var next = new List<TreeNode> ();
            for (int i = 0; i < row.Count; i++) {
                var node = row[i];
                max = Math.Max (node.val, max);
                if (node.left != null) {
                    next.Add (node.left);
                }
                if (node.right != null) {
                    next.Add (node.right);
                }
            }
            res.Add (max);
            row = next;
        }
        return res;
    }
}