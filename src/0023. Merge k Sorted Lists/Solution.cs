/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeKLists (ListNode[] lists) {
        if (lists.Length == 0) {
            return null;
        }
        while (lists.Length > 1) {
            var roundRes = new List<ListNode> ();
            for (int i = 0; i < lists.Length; i = i + 2) {
                if (i + 1 < lists.Length) {
                    roundRes.Add (MergeTwoLists (lists[i], lists[i + 1]));
                } else {
                    roundRes.Add (lists[i]);
                }
            }
            lists = roundRes.ToArray ();
        }
        return lists[0];
    }

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