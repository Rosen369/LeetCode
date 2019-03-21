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
    public IList<int> PreorderTraversal (TreeNode root) {
        var res = new List<int> ();
        Recursive (res, root);
        return res;
    }

    public void Recursive (IList<int> res, TreeNode node) {
        if (node == null) {
            return;
        }
        res.Add (node.val);
        Recursive (res, node.left);
        Recursive (res, node.right);
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
            res.Add (top.val);
            if (top.right != null) {
                stack.Push (top.right);
            }
            if (top.left != null) {
                stack.Push (top.left);
            }
        }
        return res;
    }
}