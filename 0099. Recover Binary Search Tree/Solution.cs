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
    public void RecoverTree (TreeNode root) {
        var list = new List<TreeNode> ();
        Inorder (root, list);
        var start = 0;
        for (int i = 0; i < list.Count () - 1; i++) {
            if (list[i].val > list[i + 1].val) {
                start = i;
                break;
            }
        }
        var end = list.Count () - 1;
        for (int i = start + 1; i < list.Count (); i++) {
            if (list[start].val < list[i].val) {
                end = i - 1;
                break;
            }
        }
        var temp = list[start].val;
        list[start].val = list[end].val;
        list[end].val = temp;
    }

    public void Inorder (TreeNode root, IList<TreeNode> list) {
        if (root == null) {
            return;
        }
        Inorder (root.left, list);
        list.Add (root);
        Inorder (root.right, list);
    }
}