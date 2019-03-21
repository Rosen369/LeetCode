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
    public int KthSmallest (TreeNode root, int k) {
        return InOrder (root, ref k);
    }

    public int InOrder (TreeNode root, ref int k) {
        if (root == null) {
            return -1;
        }
        var left = InOrder (root.left, ref k);
        if (left != -1) {
            return left;
        }
        if (--k == 0) {
            return root.val;
        }
        var right = InOrder (root.right, ref k);
        if (right != -1) {
            return right;
        }
        return -1;
    }
}