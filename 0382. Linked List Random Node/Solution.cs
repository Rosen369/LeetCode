/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {

    /** @param head The linked list's head.
        Note that the head is guaranteed to be not null, so it contains at least one node. */
    public Solution (ListNode head) {
        this._random = new Random ();
        this._head = head;
    }

    private Random _random;

    private ListNode _head;

    /** Returns a random node's value. */
    public int GetRandom () {
        var curr = this._head;
        var reservoir = curr.val;
        var index = 1;
        while (curr != null) {
            var p = this._random.Next (index);
            if (p == 0) {
                reservoir = curr.val;
            }
            curr = curr.next;
            index++;
        }
        return reservoir;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */