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
    public int MaxPathSum (TreeNode root) {
        if (root == null) {
            return int.MinValue;
        }
        var curr = root.val;
        var leftMax = MaxPathSum (root.left);
        var rightMax = MaxPathSum (root.right);
        if (root.left != null) {
            curr = Math.Max (curr, root.val + root.left.val);
        }
        if (root.right != null) {
            curr = Math.Max (curr, root.val + root.right.val);
        }
        var max = curr;
        if (root.left != null && root.right != null) {
            max = Math.Max (max, root.val + root.left.val + root.right.val);
        }
        var childMax = Math.Max (leftMax, rightMax);
        root.val = curr;
        return Math.Max (max, childMax);
    }
}