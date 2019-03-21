/**
 * Definition for undirected graph.
 * public class UndirectedGraphNode {
 *     public int label;
 *     public IList<UndirectedGraphNode> neighbors;
 *     public UndirectedGraphNode(int x) { label = x; neighbors = new List<UndirectedGraphNode>(); }
 * };
 */
public class Solution {
    public UndirectedGraphNode CloneGraph (UndirectedGraphNode node) {
        var dict = new Dictionary<int, UndirectedGraphNode> ();
        var clone = DFS (node, dict);
        return clone;
    }

    public UndirectedGraphNode DFS (UndirectedGraphNode node, Dictionary<int, UndirectedGraphNode> dict) {
        if (node == null) {
            return null;
        }
        if (dict.ContainsKey (node.label)) {
            return dict[node.label];
        }
        var clone = new UndirectedGraphNode (node.label);
        dict.Add (clone.label, clone);
        foreach (var neighbor in node.neighbors) {
            if (dict.ContainsKey (neighbor.label)) {
                clone.neighbors.Add (dict[neighbor.label]);
            } else {
                clone.neighbors.Add (DFS (neighbor, dict));
            }
        }
        return clone;
    }
}