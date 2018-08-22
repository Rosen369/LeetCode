public class Solution {
    public IList<TreeNode> GenerateTrees (int n) {
        if (n == 0) {
            return new List<TreeNode> ();
        }
        return GenerateSubTrees (1, n);
    }

    public IList<TreeNode> GenerateSubTrees (int start, int end) {
        var res = new List<TreeNode> ();
        if (start > end) {
            res.Add (null);
            return res;
        }
        for (int i = start; i <= end; i++) {
            var leftTrees = GenerateSubTrees (start, i - 1);
            var rightTrees = GenerateSubTrees (i + 1, end);
            foreach (var leftTree in leftTrees) {
                foreach (var rightTree in rightTrees) {
                    var root = new TreeNode (i);
                    root.left = leftTree;
                    root.right = rightTree;
                    res.Add (root);
                }
            }
        }
        return res;
    }
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode (int x) { val = x; }
}