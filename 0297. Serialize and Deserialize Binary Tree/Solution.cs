/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize (TreeNode root) {
        if (root == null) {
            return string.Empty;
        }
        var left = serialize (root.left);
        var right = serialize (root.right);
        var res = root.val + ",[" + left + "],[" + right + "]";
        return res;
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize (string data) {
        if (string.IsNullOrEmpty (data)) {
            return null;
        }
        var split = data.Split (',', 2);
        var rootStr = split[0];
        var childStr = split[1];
        var root = new TreeNode (Convert.ToInt32 (rootStr));
        var countBrace = 0;
        var childSep = 0;
        for (int i = 0; i < childStr.Length; i++) {
            if (childStr[i] == '[') {
                countBrace++;
            } else if (childStr[i] == ']') {
                countBrace--;
            }
            if (countBrace == 0) {
                childSep = i + 1;
                break;
            }
        }
        var leftStr = childStr.Substring (0, childSep);
        var rightStr = childStr.Substring (childSep + 1);
        var left = deserialize (leftStr.TrimStart ('[').TrimEnd (']'));
        var right = deserialize (rightStr.TrimStart ('[').TrimEnd (']'));
        root.left = left;
        root.right = right;
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));