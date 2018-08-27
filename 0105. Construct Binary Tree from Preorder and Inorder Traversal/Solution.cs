public class Solution {
    public TreeNode BuildTree (int[] preorder, int[] inorder) {
        if (preorder.Length == 0 || inorder.Length == 0) {
            return null;
        }
        var curr = new TreeNode (preorder[0]);
        var inorderLeft = new List<int> ();
        var inorderRight = new List<int> ();
        var metCurr = false;
        for (int i = 0; i < inorder.Length; i++) {
            if (inorder[i] == preorder[0]) {
                metCurr = true;
                continue;
            }
            if (!metCurr) {
                inorderLeft.Add (inorder[i]);
            } else {
                inorderRight.Add (inorder[i]);
            }
        }
        var preorderLeft = new List<int> ();
        var preorderRight = new List<int> ();
        var metInorder = true;
        for (int i = 1; i < preorder.Length; i++) {
            if (!inorderLeft.Contains (preorder[i])) {
                metInorder = false;
            }
            if (metInorder) {
                preorderLeft.Add (preorder[i]);
            } else {
                preorderRight.Add (preorder[i]);
            }
        }
        curr.left = BuildTree (preorderLeft.ToArray (), inorderLeft.ToArray ());
        curr.right = BuildTree (preorderRight.ToArray (), inorderRight.ToArray ());
        return curr;
    }
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode (int x) { val = x; }
}