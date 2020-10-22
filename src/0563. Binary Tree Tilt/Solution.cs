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

    private int _treeTilt = 0;

    public int FindTilt (TreeNode root) {
        this.DFS (root);
        return this._treeTilt;
    }

    private int DFS (TreeNode node) {
        if (node == null) {
            return 0;
        }
        var left = this.DFS (node.left);
        var right = this.DFS (node.right);
        var res = node.val + left + right;

        this._treeTilt += Math.Abs (left - right);
        return res;
    }
}