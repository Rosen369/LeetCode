public class Solution {
    public ListNode DeleteDuplicates (ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }
        var res = new ListNode (-1);
        var cache = res;
        var mark = head;
        var curr = head.next;
        if (mark.val != curr.val) {
            cache.next = new ListNode (mark.val);
            cache = cache.next;
        }
        while (curr != null) {
            if (curr.val == mark.val) {
                curr = curr.next;
                continue;
            }
            if (curr.next == null) {
                cache.next = curr;
                break;
            }
            if (curr.val == curr.next.val) {
                mark = curr;
                curr = curr.next;
                continue;
            }
            cache.next = new ListNode (curr.val);
            cache = cache.next;
            curr = curr.next;
        }
        return res.next;
    }
}

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode (int x) { val = x; }
}