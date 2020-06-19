/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int GetMinimumDifference (TreeNode root) {
        var list = new List<int> ();
        return this.PreOrder (root, list);
    }

    private int PreOrder (TreeNode node, IList<int> list) {
        var min = int.MaxValue;
        if (node == null) {
            return min;
        }
        var leftDiff = this.PreOrder (node.left, list);
        list.Add (node.val);
        if (list.Count > 1) {
            min = list[list.Count - 1] - list[list.Count - 2];
        }
        var rightDiff = this.PreOrder (node.right, list);
        min = Math.Min (min, leftDiff);
        min = Math.Min (min, rightDiff);
        return min;
    }
}