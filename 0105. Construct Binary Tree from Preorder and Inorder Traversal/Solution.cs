public class Solution {
    public TreeNode BuildTree (int[] preorder, int[] inorder) {
        return Build (preorder, inorder, 0, preorder.Length - 1, 0, inorder.Length - 1);
    }

    public TreeNode Build (int[] preorder, int[] inorder, int preStart, int preEnd, int inStart, int inEnd) {
        if (preStart > preEnd) {
            return null;
        }
        var curr = new TreeNode (preorder[preStart]);
        var pos = 0;
        for (int i = inStart; i <= inEnd; i++) {
            if (inorder[i] == curr.val) {
                pos = i;
                break;
            }
        }
        curr.left = Build (preorder, inorder, preStart + 1, preStart + pos - inStart, inStart, pos - 1);
        curr.right = Build (preorder, inorder, preEnd - inEnd + pos + 1, preEnd, pos + 1, inEnd);
        return curr;
    }
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode (int x) { val = x; }
}