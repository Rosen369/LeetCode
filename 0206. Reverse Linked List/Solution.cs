/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList (ListNode head) {
        return Iterative (head);
    }

    public ListNode Iterative (ListNode head) {
        ListNode res = null;
        ListNode next = null;
        while (head != null) {
            res = head;
            head = head.next;
            res.next = next;
            next = res;
        }
        return res;
    }

    public ListNode Recursive (ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }
        var pre = Recursive (head.next);
        head.next.next = head;
        head.next = null;
        return pre;
    }
}