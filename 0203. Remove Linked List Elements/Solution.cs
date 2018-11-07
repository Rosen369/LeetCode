/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveElements (ListNode head, int val) {
        var res = new ListNode (0);
        var curr = res;
        while (head != null) {
            if (head.val != val) {
                curr.next = head;
                curr = curr.next;
            }
            var pre = head;
            head = head.next;
            pre.next = null;
        }
        return res.next;
    }
}