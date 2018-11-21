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
    public int CountNodes (TreeNode root) {
        if (root == null) {
            return 0;
        }
        var left = root;
        var right = root;
        var level = 0;
        while (right != null) {
            level++;
            right = right.right;
            left = left.left;
        }
        if (left == null) {
            return (int) Math.Pow (2, level) - 1;
        }
        return 1 + CountNodes (root.left) + CountNodes (root.right);
    }
}