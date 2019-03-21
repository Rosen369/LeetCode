/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs (ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }
        var res = head.next;
        head.next = SwapPairs (head.next.next);
        res.next = head;
        return res;
    }
}