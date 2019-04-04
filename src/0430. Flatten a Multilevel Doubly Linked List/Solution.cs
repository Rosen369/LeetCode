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
            var next = node.next;
            var child = node.child;
            node.next = null;
            node.prev = null;
            node.child = null;
            curr.next = node;
            node.prev = curr;
            curr = curr.next;
            if (child != null) {
                curr = DFS (child, curr);
            }
            node = next;
        }
        return curr;
    }
}