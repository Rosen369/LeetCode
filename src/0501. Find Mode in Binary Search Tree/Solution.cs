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
    public int[] FindMode (TreeNode root) {
        var res = new List<int> ();
        var dict = new Dictionary<int, int> ();
        this.Count (root, dict);
        var max = int.MinValue;
        var values = dict.Values.ToList ();
        for (int i = 0; i < values.Count; i++) {
            max = Math.Max (max, values[i]);
        }
        var keys = dict.Keys.ToList ();
        for (int i = 0; i < keys.Count; i++) {
            if (dict[keys[i]] == max) { res.Add (keys[i]); }
        }
        return res.ToArray ();
    }

    private void Count (TreeNode node, IDictionary<int, int> dict) {
        if (node == null) { return; }
        var val = node.val;
        if (!dict.ContainsKey (val)) { dict.Add (val, 0); }
        dict[val]++;
        this.Count (node.left, dict);
        this.Count (node.right, dict);
    }
}