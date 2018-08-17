public class Solution {
    public ListNode Partition (ListNode head, int x) {
        var less = new ListNode (-1);
        var currLess = less;
        var greater = new ListNode (-1);
        var currGreater = greater;
        while (head != null) {
            if (head.val < x) {
                currLess.next = new ListNode (head.val);
                currLess = currLess.next;
            } else {
                currGreater.next = new ListNode (head.val);
                currGreater = currGreater.next;
            }
            head = head.next;
        }
        currLess.next = greater.next;
        return less.next;
    }
}

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode (int x) { val = x; }
}