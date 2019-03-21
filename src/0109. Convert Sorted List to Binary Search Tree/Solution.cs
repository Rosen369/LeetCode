/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
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
    public TreeNode SortedListToBST (ListNode head) {
        var numList = new List<int> ();
        while (head != null) {
            numList.Add (head.val);
            head = head.next;
        }
        return Build (numList.ToArray (), 0, numList.Count () - 1);
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