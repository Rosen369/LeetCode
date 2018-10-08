/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle (ListNode head) {
        if (head == null) {
            return null;
        }
        var walker = head;
        var runner = head;
        while (runner != null && runner.next != null) {
            walker = walker.next;
            runner = runner.next.next;
            if (walker == runner) {
                runner = head;
                while (runner != walker) {
                    walker = walker.next;
                    runner = runner.next;
                }
                return walker;
            }
        }
        return null;
    }
}