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
    public IList<int> InorderTraversal (TreeNode root) {
        var res = new List<int> ();
        if (root == null) {
            return res;
        }
        Inorder (root, res);
        return res;
    }

    public void Inorder (TreeNode root, IList<int> list) {
        if (root.left != null) {
            Inorder (root.left, list);
        }
        list.Add (root.val);
        if (root.right != null) {
            Inorder (root.right, list);
        }
    }

    public IList<int> Iterating (TreeNode root) {
        var res = new List<int> ();
        var stack = new Stack<TreeNode> ();
        var curr = root;
        while (curr != null || stack.Count () != 0) {
            while (curr != null) {
                stack.Push (curr);
                curr = curr.left;
            }
            curr = stack.Pop ();
            res.Add (curr.val);
            curr = curr.right;
        }
        return res;
    }
}

/*
In-order (LNR)
	1.Check if the current node is empty or null.
	2.Traverse the left subtree by recursively calling the in-order function.
	3.Display the data part of the root (or current node).
	4.Traverse the right subtree by recursively calling the in-order function.
In a binary search tree, in-order traversal retrieves data in sorted order.
 */