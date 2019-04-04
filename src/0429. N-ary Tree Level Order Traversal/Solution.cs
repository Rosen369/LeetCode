/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node(){}
    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
}
*/
public class Solution {
    public IList<IList<int>> LevelOrder (Node root) {
        var res = new List<IList<int>> ();
        if (root == null) {
            return res;
        }
        var level = new List<Node> ();
        level.Add (root);
        while (level.Count != 0) {
            var curr = new List<int> ();
            var next = new List<Node> ();
            foreach (var node in level) {
                curr.Add (node.val);
                next.AddRange (node.children);
            }
            res.Add (curr);
            level = next;
        }
        return res;
    }
}