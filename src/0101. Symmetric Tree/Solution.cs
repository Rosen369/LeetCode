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
    public bool IsSymmetric (TreeNode root) {
        if (root == null) {
            return true;
        }
        return Recursion (root.left, root.right);
    }

    public bool Recursion (TreeNode left, TreeNode right) {
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
        return Recursion (left.left, right.right) && Recursion (left.right, right.left);
    }

    public bool Iterative (TreeNode root) {
        if (root == null) {
            return true;
        }
        var queue = new Queue<TreeNode> ();
        queue.Enqueue (root.left);
        queue.Enqueue (root.right);
        while (queue.Count () != 0) {
            var left = queue.Dequeue ();
            var right = queue.Dequeue ();
            if (left == null && right == null) {
                continue;
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
            queue.Enqueue (left.left);
            queue.Enqueue (right.right);
            queue.Enqueue (left.right);
            queue.Enqueue (right.left);
        }
        return true;
    }
}