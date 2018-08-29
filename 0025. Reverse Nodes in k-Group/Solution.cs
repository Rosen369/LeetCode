/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseKGroup (ListNode head, int k) {
        var pre = new ListNode (0);
        var curr = pre;
        var index = 0;
        var buffer = new ListNode[k];
        while (head != null) {
            buffer[index] = head;
            head = head.next;
            buffer[index].next = null;
            if (index == k - 1) {
                for (int i = k - 1; i >= 0; i--) {
                    curr.next = buffer[i];
                    curr = curr.next;
                }
                index = 0;
                continue;
            }
            index++;
        }
        for (int i = 0; i < index; i++) {
            curr.next = buffer[i];
            curr = curr.next;
        }
        return pre.next;
    }
}