public class Solution {
    public void Connect (TreeLinkNode root) {
        if (root == null) {
            return;
        }
        if (root.left == null || root.right == null) {
            return;
        }
        root.left.next = root.right.next;
        if (root.next != null) {
            root.right.next = root.next.left;
        }
        Connect (root.left);
        Connect (root.right);
    }
}

public class TreeLinkNode {
    public int val;
    public TreeLinkNode left;
    public TreeLinkNode right;
    public TreeLinkNode next;
    public TreeLinkNode (int x) { val = x; }
}