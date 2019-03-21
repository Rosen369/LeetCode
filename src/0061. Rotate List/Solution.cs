/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RotateRight (ListNode head, int k) {
        if (k == 0 || head == null) {
            return head;
        }
        //count nodes
        var count = 0;
        var curr = head;
        while (curr != null) {
            count++;
            curr = curr.next;
        }
        //calc nodes roate
        k = k % count;
        if (k == 0) {
            return head;
        }
        curr = head;
        //get last node
        var last = curr;
        for (int i = 0; i < count - k; i++) {
            last = curr;
            curr = curr.next;
        }
        //get front node
        var front = curr;
        for (int i = 0; i < k - 1; i++) {
            curr = curr.next;
        }
        curr.next = head;
        last.next = null;
        return front;
    }
}