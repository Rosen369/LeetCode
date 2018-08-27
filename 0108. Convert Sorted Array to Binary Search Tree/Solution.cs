public class Solution {
    public TreeNode SortedArrayToBST (int[] nums) {
        return Build (nums, 0, nums.Length - 1);
    }

    public TreeNode Build (int[] nums, int start, int end) {
        if (start > end) {
            return null;
        }
        var mid = (start + end) / 2;
        var node = new TreeNode (nums[mid]);
        node.left = Build (nums, start, mid - 1);
        node.right = Build (nums, mid + 1, end);
        return node;
    }
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode (int x) { val = x; }
}