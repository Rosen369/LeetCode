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
    public int Rob (TreeNode root) {
        var res = RobSub (root);
        return Math.Max (res[0], res[1]);
    }
    
    private int[] RobSub (TreeNode root) {
        if (root == null) return new int[2];
        var left = RobSub (root.left);
        var right = RobSub (root.right);
        var res = new int[2];
        res[0] = Math.Max (left[0], left[1]) + Math.Max (right[0], right[1]);
        res[1] = root.val + left[0] + right[0];
        return res;
    }
}