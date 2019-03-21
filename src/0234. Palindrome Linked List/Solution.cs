/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsPalindrome (ListNode head) {
        if (head == null || head.next == null) {
            return true;
        }
        var slow = head;
        var fast = head;
        while (fast.next != null && fast.next.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        slow = slow.next;
        var end = this.Reverse (slow);
        var start = head;
        while (end != null) {
            if (start.val != end.val) {
                return false;
            }
            start = start.next;
            end = end.next;
        }
        return true;
    }

    private ListNode Reverse (ListNode head) {
        ListNode res = null;
        while (head != null) {
            var curr = head;
            head = head.next;
            curr.next = res;
            res = curr;
        }
        return res;
    }
}