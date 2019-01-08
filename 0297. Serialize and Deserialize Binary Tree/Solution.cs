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
        var sb = new StringBuilder ();
        var curr = new List<TreeNode> ();
        curr.Add (root);
        while (curr.Count () != 0) {
            var nullRow = true;
            var next = new List<TreeNode> ();
            foreach (var node in curr) {
                if (node == null) {
                    next.Add (null);
                    next.Add (null);
                    sb.Append ("null,");
                } else {
                    next.Add (node.left);
                    next.Add (node.right);
                    sb.Append (node.val).Append (",");
                    if (node.left != null || node.right != null) {
                        nullRow = false;
                    }
                }
            }
            if (nullRow) {
                break;
            }
            curr = next;
        }
        return sb.ToString ().TrimEnd(',');
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize (string data) {
        if (string.IsNullOrEmpty (data)) {
            return null;
        }
        var arr = data.Split (',');
        var root = new TreeNode (Convert.ToInt32 (arr[0]));
        var index = 1;
        var queue = new Queue<TreeNode> ();
        queue.Enqueue (root);
        while (queue.Count () != 0 && index <= arr.Length - 1) {
            var node = queue.Dequeue ();
            if (node == null) {
                queue.Enqueue (null);
                queue.Enqueue (null);
                index += 2;
            } else {
                if (arr[index] == "null") {
                    queue.Enqueue (null);
                } else {
                    var child = new TreeNode (Convert.ToInt32 (arr[index]));
                    node.left = child;
                    queue.Enqueue (child);
                }
                index++;
                if (arr[index] == "null") {
                    queue.Enqueue (null);
                } else {
                    var child = new TreeNode (Convert.ToInt32 (arr[index]));
                    node.right = child;
                    queue.Enqueue (child);
                }
                index++;
            }
        }
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));