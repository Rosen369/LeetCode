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
        var oriList = new List<RandomListNode> ();
        while (curr != null) {
            oriList.Add (curr);
            curr = curr.next;
        }
        var copyList = new List<RandomListNode> ();
        for (int i = 0; i < oriList.Count (); i++) {
            copyList.Add (new RandomListNode (oriList[i].label));
            if (i != 0) {
                copyList[i - 1].next = copyList[i];
            }
        }
        for (int i = 0; i < oriList.Count (); i++) {
            if (oriList[i].random == null) {
                continue;
            }
            for (int j = 0; j < oriList.Count (); j++) {
                if (Object.ReferenceEquals (oriList[i].random, oriList[j])) {
                    copyList[i].random = copyList[j];
                }
            }
        }
        return copyList[0];
    }
}