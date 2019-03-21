/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode InsertionSortList (ListNode head) {
        if (head == null) {
            return null;
        }
        var curr = head;
        var next = curr.next;
        head.next = null;
        while (next != null) {
            curr = next;
            next = curr.next;
            curr.next = null;
            if (curr.val < head.val) {
                curr.next = head;
                head = curr;
            } else {
                var front = head;
                while (true) {
                    if (front.next == null || front.next.val > curr.val) {
                        break;
                    }
                    front = front.next;
                }
                var tail = front.next;
                front.next = curr;
                curr.next = tail;
            }
        }
        return head;
    }
}