/**
 * Definition for a binary tree node.
 * public class TreeLinkNode {
 *     public int val;
 *     public TreeLinkNode left;
 *     public TreeLinkNode right;
 *     public TreeLinkNode next;
 *     public TreeLinkNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void Connect (TreeLinkNode root) {
        if (root == null) {
            return;
        }
        var curr = new List<TreeLinkNode> ();
        var next = new List<TreeLinkNode> ();
        curr.Add (root);
        while (curr.Count () != 0) {
            next.Clear ();
            for (int i = 0; i < curr.Count (); i++) {
                var node = curr[i];
                if (i != curr.Count () - 1) {
                    node.next = curr[i + 1];
                }
                if (node.left != null) {
                    next.Add (node.left);
                }
                if (node.right != null) {
                    next.Add (node.right);
                }
            }
            curr.Clear ();
            curr.AddRange (next);
        }
    }
}