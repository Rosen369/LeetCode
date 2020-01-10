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
    public int FindBottomLeftValue (TreeNode root) {
        var res = 0;
        var queue = new Queue<TreeNode> ();
        queue.Enqueue (root);
        while (queue.Count > 0) {
            var count = queue.Count;
            res = queue.Peek ().val;
            for (int i = 0; i < count; i++) {
                var node = queue.Dequeue ();
                if (node.left != null) {
                    queue.Enqueue (node.left);
                }
                if (node.right != null) {
                    queue.Enqueue (node.right);
                }
            }
        }
        return res;
    }
}