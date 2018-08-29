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
    public IList<IList<int>> PathSum (TreeNode root, int sum) {
        var res = new List<IList<int>> ();
        MoveNext (root, sum, res, new List<int> ());
        return res;
    }

    public void MoveNext (TreeNode root, int sum, IList<IList<int>> res, IList<int> curr) {
        if (root == null) {
            return;
        }
        curr.Add (root.val);
        if (root.left == null && root.right == null) {
            if (root.val == sum) {
                res.Add (new List<int> (curr));
            }
        } else {
            MoveNext (root.left, sum - root.val, res, curr);
            MoveNext (root.right, sum - root.val, res, curr);
        }
        curr.RemoveAt (curr.Count () - 1);
    }
}