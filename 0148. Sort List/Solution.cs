/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SortList (ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }

        var fast = head;
        var slow = head;
        while (fast.next != null && fast.next.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        var mid = slow.next;
        slow.next = null;

        head = SortList (head);
        mid = SortList (mid);

        var res = new ListNode (0);
        var curr = res;
        while (head != null || mid != null) {
            if (head == null) {
                curr.next = mid;
                break;
            }
            if (mid == null) {
                curr.next = head;
                break;
            }
            if (head.val < mid.val) {
                curr.next = head;
                head = head.next;
                curr = curr.next;
            } else {
                curr.next = mid;
                mid = mid.next;
                curr = curr.next;
            }
        }
        return res.next;
    }
}