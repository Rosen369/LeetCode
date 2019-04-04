/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;

    public Node(){}
    public Node(int _val,Node _prev,Node _next,Node _child) {
        val = _val;
        prev = _prev;
        next = _next;
        child = _child;
}
*/
public class Solution {
    public Node Flatten (Node head) {
        if (head == null) {
            return null;
        }
        var res = new Node (0, null, null, null);
        var curr = res;
        this.DFS (head, curr);
        res = res.next;
        res.prev = null;
        return res;
    }

    private Node DFS (Node node, Node curr) {
        while (node != null) {
            curr.next = new Node (node.val, curr, null, null);
            curr = curr.next;
            if (node.child != null) {
                curr = DFS (node.child, curr);
            }
            node = node.next;
        }
        return curr;
    }
}