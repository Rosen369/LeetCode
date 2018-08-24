public class Solution {
    public bool IsSymmetric (TreeNode root) {
        if (root == null) {
            return true;
        }
        return Symmetric (root.left, root.right);
    }

    public bool Symmetric (TreeNode left, TreeNode right) {
        if (left == null && right == null) {
            return true;
        }
        if (left != null && right == null) {
            return false;
        }
        if (left == null & right != null) {
            return false;
        }
        if (left.val != right.val) {
            return false;
        }
        return Symmetric (left.left, right.right) && Symmetric (left.right, right.left);
    }
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode (int x) { val = x; }
}