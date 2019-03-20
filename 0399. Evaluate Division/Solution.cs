public class Solution {
    public double[] CalcEquation (string[, ] equations, double[] values, string[, ] queries) {
        var len = equations.GetLength (0);
        var dict = new Dictionary<string, IList<Node>> ();
        for (int i = 0; i < len; i++) {
            var from = equations[i, 0];
            var to = equations[i, 1];
            if (!dict.ContainsKey (from)) {
                dict.Add (from, new List<Node> ());
            }
            if (!dict.ContainsKey (to)) {
                dict.Add (to, new List<Node> ());
            }
            dict[from].Add (new Node (from, to, values[i]));
            dict[to].Add (new Node (to, from, 1 / values[i]));
        }
        var qLen = queries.GetLength (0);
        var res = new double[qLen];
        for (int i = 0; i < qLen; i++) {
            res[i] = DFS (dict, queries[i, 0], queries[i, 1], new HashSet<string> ());
        }
        return res;
    }

    private double DFS (IDictionary<string, IList<Node>> dict, string from, string to, HashSet<string> path) {
        if (!dict.ContainsKey (from)) {
            return -1;
        }
        path.Add (from);
        var nodeList = dict[from];
        for (int i = 0; i < nodeList.Count; i++) {
            var node = nodeList[i];
            if (node.To == to) {
                return node.Value;
            }
            if (path.Contains (node.To)) {
                continue;
            }
            var next = DFS (dict, node.To, to, path);
            if (next != -1) {
                return next * node.Value;
            }
        }
        path.Remove (from);
        return -1;
    }

    private class Node {
        public Node (string from, string to, double value) {
            this.From = from;
            this.To = to;
            this.Value = value;
        }

        public string From { get; private set; }

        public string To { get; private set; }

        public double Value { get; private set; }
    }
}