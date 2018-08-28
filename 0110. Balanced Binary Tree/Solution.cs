public class Solution {
    public bool IsBalanced (TreeNode root) {
        if (root == null) {
            return true;
        }
        return Depth (root) != -1;
    }

    public int Depth (TreeNode root) {
        if (root == null) {
            return 0;
        }
        var left = Depth (root.left);
        if (left == -1) {
            return -1;
        }
        var right = Depth (root.right);
        if (right == -1) {
            return -1;
        }
        if (left - right > 1 || right - left > 1) {
            return -1;
        }
        return Math.Max (left, right) + 1;
    }
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode (int x) { val = x; }
}