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

    private int _sum = 0;

    public TreeNode ConvertBST (TreeNode root) {
        this.PostOrder (root);
        return root;
    }

    private void PostOrder (TreeNode node) {
        if (node == null) {
            return;
        }
        this.PostOrder (node.right);
        this._sum += node.val;
        node.val = this._sum;
        this.PostOrder (node.left);
    }
}