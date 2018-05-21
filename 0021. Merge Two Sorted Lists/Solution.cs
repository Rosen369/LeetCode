public class Solution {
    public ListNode MergeTwoLists (ListNode l1, ListNode l2) {
        if (l1 == null) {
            return l2;
        }
        if (l2 == null) {
            return l1;
        }
        ListNode res = null;
        if (l1.val < l2.val) {
            res = l1;
            res.next = MergeTwoLists (l1.next, l2);
        } else {
            res = l2;
            res.next = MergeTwoLists (l1, l2.next);
        }
        return res;
    }
}

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode (int x) { val = x; }
}