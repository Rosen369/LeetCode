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
    public TreeNode DeleteNode (TreeNode root, int key) {
        if (root == null) {
            return null;
        }
        if (root.val > key) {
            root.left = this.DeleteNode (root.left, key);
        } else if (root.val < key) {
            root.right = this.DeleteNode (root.right, key);
        } else {
            if (root.left == null) {
                return root.right;
            }
            if (root.right == null) {
                return root.left;
            }
            var minNode = this.FindMinNode (root.right);
            root.val = minNode.val;
            root.right = this.DeleteNode (root.right, root.val);
        }
        return root;
    }

    private TreeNode FindMinNode (TreeNode node) {
        while (node.left != null) {
            node = node.left;
        }
        return node;
    }
}