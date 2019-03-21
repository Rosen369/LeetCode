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
    public bool IsValidBST (TreeNode root) {
        var list = new List<int> ();
        Inorder (root, list);
        for (int i = 1; i < list.Count (); i++) {
            if (list[i] <= list[i - 1]) {
                return false;
            }
        }
        return true;
    }

    public void Inorder (TreeNode root, IList<int> res) {
        if (root == null) {
            return;
        }
        if (root.left != null) {
            Inorder (root.left, res);
        }
        res.Add (root.val);
        if (root.right != null) {
            Inorder (root.right, res);
        }
    }
}