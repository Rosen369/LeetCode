public class Solution {
    public ListNode DeleteDuplicates (ListNode head) {
        var list = new List<int> ();
        while (head != null) {
            if (!list.Contains (head.val)) {
                list.Add (head.val);
            }
            head = head.next;
        }
        var res = new ListNode (0);
        var curr = res;
        for (int i = 0; i < list.Count (); i++) {
            curr.next = new ListNode (list[i]);
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