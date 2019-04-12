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
    //DFS solution
    //Runtime: 116 ms
    //Memory Usage: 23.9 MB
    public int PathSum (TreeNode root, int sum) {
        if (root == null) {
            return 0;
        }
        var left = PathSum (root.left, sum);
        var right = PathSum (root.right, sum);
        var curr = DFS (root, sum, 0);
        return curr + left + right;
    }

    private int DFS (TreeNode root, int sum, int pre) {
        var res = 0;
        if (root == null) {
            return res;
        }
        var current = root.val + pre;
        if (current == sum) {
            res++;
        }
        res += DFS (root.left, sum, current);
        res += DFS (root.right, sum, current);
        return res;
    }
}