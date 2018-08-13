public class Solution {
    public ListNode DeleteDuplicates (ListNode head) {
        var dic = new Dictionary<int, int> ();
        while (head != null) {
            if (dic.ContainsKey (head.val)) {
                dic[head.val] = dic[head.val] + 1;
            } else {
                dic.Add (head.val, 1);
            }
            head = head.next;
        }
        var res = new ListNode (0);
        curr = res;
        foreach (var pair in dic) {
            if (pair.Value == 1) {
                curr.next = new ListNode (pair.Key);
                curr = curr.next;
            }
        }
        return res.next;
    }
}

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode (int x) { val = x; }
}