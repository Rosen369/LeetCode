/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {

    private int _max = 0;

    public int DiameterOfBinaryTree (TreeNode root) {
        this.Depth (root);
        return this._max;
    }

    private int Depth (TreeNode node) {
        if (node == null) {
            return 0;
        }
        var left = this.Depth (node.left);
        var right = this.Depth (node.right);

        this._max = Math.Max (this._max, left + right);
        return Math.Max (left, right) + 1;
    }
}