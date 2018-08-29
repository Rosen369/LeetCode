/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseBetween (ListNode head, int m, int n) {
        var res = new ListNode (-1);
        var curr = res;
        var list = new List<int> ();
        while (head != null) {
            list.Add (head.val);
            head = head.next;
        }
        for (int i = 0; i < list.Count (); i++) {
            if (i == m - 1) {
                i = n - 1;
                for (; i >= m - 1; i--) {
                    curr.next = new ListNode (list[i]);
                    curr = curr.next;
                }
                i = n - 1;
            } else {
                curr.next = new ListNode (list[i]);
                curr = curr.next;
            }
        }
        return res.next;
    }
}