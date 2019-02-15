/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode OddEvenList (ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }
        var odd = head;
        var even = head.next;
        var isOdd = true;
        var curr = even.next;
        odd.next = null;
        even.next = null;
        var currOdd = odd;
        var currEven = even;
        while (curr != null) {
            if (isOdd) {
                currOdd.next = curr;
                curr = curr.next;
                currOdd = currOdd.next;
                currOdd.next = null;
                isOdd = false;
            } else {
                currEven.next = curr;
                curr = curr.next;
                currEven = currEven.next;
                currEven.next = null;
                isOdd = true;
            }
        }
        currOdd.next = even;
        return odd;
    }
}