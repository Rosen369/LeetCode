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
    public TreeNode LowestCommonAncestor (TreeNode root, TreeNode p, TreeNode q) {
        var pathToP = new List<TreeNode> ();
        var pathToQ = new List<TreeNode> ();
        PathToNode (root, p, pathToP);
        PathToNode (root, q, pathToQ);
        var min = Math.Min (pathToP.Count, pathToQ.Count);
        var max = Math.Max (pathToP.Count, pathToQ.Count);
        for (int i = 0; i < max; i++) {
            if (pathToP[i] != pathToQ[i]) {
                return pathToP[i - 1];
            }
            if (i == min - 1) {
                return pathToP[i];
            }
        }
        return root;
    }

    public bool PathToNode (TreeNode root, TreeNode n, IList<TreeNode> path) {
        if (root == null) {
            return false;
        }
        path.Add (root);
        if (root.val == n.val) {
            return true;
        }
        if (PathToNode (root.left, n, path)) {
            return true;
        }
        if (PathToNode (root.right, n, path)) {
            return true;
        }
        path.RemoveAt (path.Count () - 1);
        return false;
    }
}