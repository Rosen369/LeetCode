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
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode (int x) { val = x; }
}