public class Solution {
    public IList<int> FindMinHeightTrees (int n, int[, ] edges) {
        if (n == 1) {
            return new List<int> () { 0 };
        }
        var adjacent = new List<HashSet<int>> ();
        var edgeLen = edges.GetLength (0);
        for (int i = 0; i < n; i++) {
            adjacent.Add (new HashSet<int> ());
        }
        for (int i = 0; i < edgeLen; i++) {
            var n1 = edges[i, 0];
            var n2 = edges[i, 1];
            adjacent[n1].Add (n2);
            adjacent[n2].Add (n1);
        }
        var leaves = new List<int> ();
        for (int i = 0; i < n; i++) {
            if (adjacent[i].Count () == 1) {
                leaves.Add (i);
            }
        }
        while (n > 2) {
            n -= leaves.Count ();
            var next = new List<int> ();
            for (int i = 0; i < leaves.Count (); i++) {
                var node = leaves[i];
                if (adjacent[node].Count () > 0) {
                    var adNode = adjacent[node].First ();
                    adjacent[adNode].Remove (node);
                    if (adjacent[adNode].Count () == 1) {
                        next.Add (adNode);
                    }
                }
            }
            leaves = next;
        }
        return leaves;
    }
}