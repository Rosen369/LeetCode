/**
 * Definition for singly-linked list with a random pointer.
 * public class RandomListNode {
 *     public int label;
 *     public RandomListNode next, random;
 *     public RandomListNode(int x) { this.label = x; }
 * };
 */
public class Solution {
    public RandomListNode CopyRandomList (RandomListNode head) {
        if (head == null) {
            return null;
        }
        var curr = head;
        var ori = new List<RandomListNode> ();
        while (curr != null) {
            ori.Add (curr);
            curr = curr.next;
        }
        var dict = new Dictionary<int, RandomListNode> ();
        for (int i = 0; i < ori.Count (); i++) {
            dict.Add (ori[i].label, new RandomListNode (ori[i].label));
        }
        var copy = dict.Values.ToList ();
        for (int i = 0; i < ori.Count (); i++) {
            if (i != 0) {
                copy[i - 1].next = copy[i];
            }
            if (ori[i].random != null) {
                copy[i].random = dict[ori[i].random.label];
            }
        }
        return copy[0];
    }
}