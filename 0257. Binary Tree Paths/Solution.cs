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
    public IList<string> BinaryTreePaths (TreeNode root) {
        var res = new List<string> ();
        if (root == null) {
            return res;
        }
        var left = BinaryTreePaths (root.left);
        var right = BinaryTreePaths (root.right);
        foreach (var leftPath in left) {
            res.Add (root.val + "->" + leftPath);
        }
        foreach (var rightPath in right) {
            res.Add (root.val + "->" + rightPath);
        }
        if (res.Count == 0) {
            res.Add (root.val.ToString ());
        }
        return res;
    }
}