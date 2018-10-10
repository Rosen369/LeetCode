/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void ReorderList (ListNode head) {
        var list = new List<ListNode> ();
        while (head != null) {
            list.Add (head);
            head = head.next;
        }
        for (int i = 0; i < list.Count (); i++) {
            if (i == list.Count () / 2) {
                list[i].next = null;
                continue;
            }
            var next = list.Count () - i;
            if (i < list.Count () / 2) {
                next--;
            }
            list[i].next = list[next];
        }
    }
}