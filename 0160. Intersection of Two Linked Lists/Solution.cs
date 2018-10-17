/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode (ListNode headA, ListNode headB) {
        var countA = 0;
        var currA = headA;
        while (currA != null) {
            countA++;
            currA = currA.next;
        }
        var countB = 0;
        var currB = headB;
        while (currB != null) {
            countB++;
            currB = currB.next;
        }
        var max = Math.Max (countA, countB);
        currA = headA;
        currB = headB;
        for (int i = 0; i < max; i++) {
            if (countA == countB) {
                if (currA == currB) {
                    return currA;
                }
                currA = currA.next;
                currB = currB.next;
                countA--;
                countB--;
            } else if (countA > countB) {
                currA = currA.next;
                countA--;
            } else {
                currB = currB.next;
                countB--;
            }
        }
        return null;
    }
}