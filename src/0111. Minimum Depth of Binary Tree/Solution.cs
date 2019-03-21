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
    public int MinDepth (TreeNode root) {
        if (root == null) {
            return 0;
        }
        var left = MinDepth (root.left);
        var right = MinDepth (root.right);
        if (left == 0) {
            return right + 1;
        }
        if (right == 0) {
            return left + 1;
        }
        return Math.Min (left, right) + 1;
    }
}