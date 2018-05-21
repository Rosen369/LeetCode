public class Solution {
    public ListNode MergeTwoLists (ListNode l1, ListNode l2) {
        if (l1 == null) {
            return l2;
        }
        if (l2 == null) {
            return l1;
        }
        var head = l1;
        var current = l1;
        var insert = l2;
        if (l1.val > l2.val) {
            head = l2;
            current = l2;
            insert = l1;
        }
        while (insert != null) {
            if (current.next == null) {
                current.next = insert;
                break;
            }
            if (current.next.val > insert.val) {
                var next = current.next;
                current.next = insert;
                insert = insert.next;
                current.next.next = next;
            }
            current = current.next;
        }
        return head;
    }
}

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode (int x) { val = x; }
}