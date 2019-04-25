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
        return this.PreOrder (root);
    }

    private string PreOrder (TreeNode root) {
        if (root == null) {
            return string.Empty;
        }
        var current = root.val.ToString ();
        var left = this.PreOrder (root.left);
        var right = this.PreOrder (root.right);
        var res = current;
        if (!string.IsNullOrEmpty (left)) {
            res += ',' + left;
        }
        if (!string.IsNullOrEmpty (right)) {
            res += ',' + right;
        }
        return res;
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize (string data) {
        if (string.IsNullOrEmpty (data)) {
            return null;
        }
        var arr = data.Split (',');
        var nums = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++) {
            nums[i] = Convert.ToInt32 (arr[i]);
        }
        var res = this.DFS (nums, 0, arr.Length - 1);
        return res;
    }

    private TreeNode DFS (int[] nums, int start, int end) {
        if (start > end) {
            return null;
        }
        var current = new TreeNode (nums[start]);
        var leftEnd = end;
        for (int i = start + 1; i <= end; i++) {
            if (nums[i] > nums[start]) {
                leftEnd = i - 1;
                break;
            }
        }
        var left = this.DFS (nums, start + 1, leftEnd);
        var right = this.DFS (nums, leftEnd + 1, end);
        current.left = left;
        current.right = right;
        return current;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));