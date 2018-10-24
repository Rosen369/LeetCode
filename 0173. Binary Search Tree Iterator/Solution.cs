/**
 * Definition for binary tree
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class BSTIterator {

    public BSTIterator (TreeNode root) {
        _stack = new Stack<TreeNode> ();
        this.PushLeft (root);
    }

    private Stack<TreeNode> _stack;

    private void PushLeft (TreeNode node) {
        while (node != null) {
            _stack.Push (node);
            node = node.left;
        }
    }

    /** @return whether we have a next smallest number */
    public bool HasNext () {
        if (_stack.Count () != 0) {
            return true;
        }
        return false;
    }

    /** @return the next smallest number */
    public int Next () {
        var node = _stack.Pop ();
        this.PushLeft (node.right);
        return node.val;
    }
}

/**
 * Your BSTIterator will be called like this:
 * BSTIterator i = new BSTIterator(root);
 * while (i.HasNext()) v[f()] = i.Next();
 */