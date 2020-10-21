/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public int MaxDepth (Node root) {
        if (root == null) {
            return 0;
        }
        if (root.children.Count == 0) {
            return 1;
        }

        var max = 0;
        for (int i = 0; i < root.children.Count; i++) {
            var r = this.MaxDepth (root.children[i]);
            max = Math.Max (r, max);
        }

        return max + 1;
    }
}