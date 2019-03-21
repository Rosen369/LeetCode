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
    public int SumNumbers (TreeNode root) {
        if (root == null) {
            return 0;
        }
        var res = new List<int> ();
        DFS (root, res, 0);
        return res.Sum ();
    }

    public void DFS (TreeNode node, IList<int> res, int curr) {
        curr = curr * 10;
        curr += node.val;
        if (node.left == null && node.right == null) {
            res.Add (curr);
            return;
        }
        if (node.left != null) {
            DFS (node.left, res, curr);
        }
        if (node.right != null) {
            DFS (node.right, res, curr);
        }
    }
}