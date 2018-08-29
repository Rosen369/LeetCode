/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd (ListNode head, int n) {
        var index = 0;
        var map = new Dictionary<int, ListNode> ();
        var current = head;
        while (current != null) {
            map.Add (index, current);
            index++;
            current = current.next;
        }
        var tail = index - n;
        if (map.ContainsKey (tail - 1) && map.ContainsKey (tail + 1)) {
            map[tail - 1].next = map[tail + 1];
        } else if (map.ContainsKey (tail - 1) && !map.ContainsKey (tail + 1)) {
            map[tail - 1].next = null;
        } else if (!map.ContainsKey (tail - 1) && map.ContainsKey (tail + 1)) {
            return map[tail + 1];
        } else {
            return null;
        }
        return head;
    }
}