/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers (ListNode l1, ListNode l2) {
        var list1 = new List<int> ();
        var list2 = new List<int> ();
        while (l1 != null) {
            list1.Add (l1.val);
            l1 = l1.next;
        }
        while (l2 != null) {
            list2.Add (l2.val);
            l2 = l2.next;
        }
        var index1 = list1.Count - 1;
        var index2 = list2.Count - 1;
        var carry = 0;
        var resList = new List<int> ();
        while (index1 >= 0 || index2 >= 0) {
            if (index1 < 0) {
                var plus = list2[index2] + carry;
                resList.Add (plus % 10);
                carry = plus / 10;
                index2--;
            } else if (index2 < 0) {
                var plus = list1[index1] + carry;
                resList.Add (plus % 10);
                carry = plus / 10;
                index1--;
            } else {
                var plus = list1[index1] + list2[index2] + carry;
                resList.Add (plus % 10);
                carry = plus / 10;
                index1--;
                index2--;
            }
        }
        if (carry != 0) {
            resList.Add (carry);
        }
        var head = new ListNode (0);
        var curr = head;
        for (int i = resList.Count - 1; i >= 0; i--) {
            curr.next = new ListNode (resList[i]);
            curr = curr.next;
        }
        return head.next;
    }
}