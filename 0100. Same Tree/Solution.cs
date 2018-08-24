public class Solution {
    public bool IsSameTree (TreeNode p, TreeNode q) {
        if (p == null && q == null) {
            return true;
        }
        if (p == null && q != null) {
            return false;
        }
        if (p != null && q == null) {
            return false;
        }
        if (!IsSameTree (p.left, q.left)) {
            return false;
        }
        if (p.val != q.val) {
            return false;
        }
        if (!IsSameTree (p.right, q.right)) {
            return false;
        }
        return true;
    }
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode (int x) { val = x; }
}