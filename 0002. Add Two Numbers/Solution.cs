/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers (ListNode l1, ListNode l2) {
        var root = new ListNode (0);
        ListNode current = root;
        var carry = 0;
        while (l1 != null || l2 != null || carry != 0) {
            var val1 = l1 == null ? 0 : l1.val;
            var val2 = l2 == null ? 0 : l2.val;
            var combine = val1 + val2 + carry;
            carry = 0;
            if (combine >= 10) {
                carry = 1;
                combine = combine - 10;
            }
            current.next = new ListNode (combine);
            current = current.next;
            l1 = l1 == null ? null : l1.next ?? null;
            l2 = l2 == null ? null : l2.next ?? null;
        }
        return root.next;
    }
}