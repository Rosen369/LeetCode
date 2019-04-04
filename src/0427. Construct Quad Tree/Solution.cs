/*
// Definition for a QuadTree node.
public class Node {
    public bool val;
    public bool isLeaf;
    public Node topLeft;
    public Node topRight;
    public Node bottomLeft;
    public Node bottomRight;

    public Node(){}
    public Node(bool _val,bool _isLeaf,Node _topLeft,Node _topRight,Node _bottomLeft,Node _bottomRight) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = _topLeft;
        topRight = _topRight;
        bottomLeft = _bottomLeft;
        bottomRight = _bottomRight;
}
*/
public class Solution {
    //DFS solution
    //Runtime: 176 ms
    //Memory Usage: 34.5 MB
    public Node Construct (int[][] grid) {
        var m = grid.Length;
        var n = grid[0].Length;
        return DFS (grid, 0, m - 1, 0, n - 1);
    }

    private Node DFS (int[][] grid, int top, int bottom, int left, int right) {
        if (top == bottom && left == right) {
            return new Node (grid[top][left] == 1, true, null, null, null, null);
        }
        var mMid = (top + bottom) / 2;
        var nMid = (left + right) / 2;
        var tl = DFS (grid, top, mMid, left, nMid);
        var tr = DFS (grid, top, mMid, nMid + 1, right);
        var bl = DFS (grid, mMid + 1, bottom, left, nMid);
        var br = DFS (grid, mMid + 1, bottom, nMid + 1, right);
        if (tl.val == tr.val && tr.val == bl.val && bl.val == br.val && tl.isLeaf && tr.isLeaf && bl.isLeaf && br.isLeaf) {
            return new Node (tl.val, true, null, null, null, null);
        }
        return new Node (tl.val, false, tl, tr, bl, br);
    }
}