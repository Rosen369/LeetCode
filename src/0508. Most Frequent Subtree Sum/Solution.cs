/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int[] FindFrequentTreeSum (TreeNode root) {
        var dict = new Dictionary<int, int> ();
        this.DFS (root, dict);
        var max = 0;
        var keys = dict.Keys.ToList ();
        for (int i = 0; i < keys.Count; i++) {
            max = Math.Max (dict[keys[i]], max);
        }
        var res = new List<int> ();
        for (int i = 0; i < keys.Count; i++) {
            if (dict[keys[i]] == max) {
                res.Add (keys[i]);
            }
        }
        return res.ToArray ();
    }

    public int DFS (TreeNode node, IDictionary<int, int> dict) {
        if (node == null) {
            return 0;
        }
        var left = this.DFS (node.left, dict);
        var right = this.DFS (node.right, dict);
        var res = left + right + node.val;

        if (dict.ContainsKey (res)) {
            dict[res]++;
        } else {
            dict.Add (res, 1);
        }
        return res;
    }
}