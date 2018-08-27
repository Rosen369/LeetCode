public class Solution {
    public TreeNode BuildTree (int[] inorder, int[] postorder) {
        return Build (inorder, postorder, 0, inorder.Length - 1, 0, postorder.Length - 1);
    }

    public TreeNode Build (int[] inorder, int[] postorder, int postStart, int postEnd, int inStart, int inEnd) {
        if (postStart > postEnd) {
            return null;
        }
        var curr = new TreeNode (postorder[postEnd]);
        var pos = 0;
        for (int i = inStart; i <= inEnd; i++) {
            if (inorder[i] == curr.val) {
                pos = i;
                break;
            }
        }
        curr.left = Build (inorder, postorder, postStart, postStart + pos - inStart - 1, inStart, pos - 1);
        curr.right = Build (inorder, postorder, postEnd - inEnd + pos, postEnd - 1, pos + 1, inEnd);
        return curr;
    }
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode (int x) { val = x; }
}