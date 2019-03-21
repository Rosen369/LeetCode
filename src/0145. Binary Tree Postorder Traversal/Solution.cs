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
    public IList<int> PostorderTraversal (TreeNode root) {
        var res = new List<int> ();
        Recursive (res, root);
        return res;
    }

    public void Recursive (IList<int> res, TreeNode node) {
        if (node == null) {
            return;
        }
        Recursive (res, node.left);
        Recursive (res, node.right);
        res.Add (node.val);
    }

    public IList<int> Iterative (TreeNode root) {
        var res = new List<int> ();
        if (root == null) {
            return res;
        }
        var stack = new Stack<TreeNode> ();
        stack.Push (root);
        while (stack.Count () != 0) {
            var top = stack.Pop ();
            if (top.left == null && top.right == null) {
                res.Add (top.val);
            } else {
                var left = top.left;
                var right = top.right;
                top.left = null;
                top.right = null;
                stack.Push (top);
                if (right != null) {
                    stack.Push (right);
                }
                if (left != null) {
                    stack.Push (left);
                }
            }
        }
        return res;
    }
}