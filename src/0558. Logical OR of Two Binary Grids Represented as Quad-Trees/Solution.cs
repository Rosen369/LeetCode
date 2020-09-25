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
}
*/

public class Solution {
    public Node Intersect (Node quadTree1, Node quadTree2) {
        var value = quadTree1.val || quadTree2.val;
        if (quadTree1.isLeaf && quadTree2.isLeaf) {
            return new Node (value, true, null, null, null, null);
        }

        var qt1TL = quadTree1.isLeaf ? new Node (quadTree1.val, true, null, null, null, null) : quadTree1.topLeft;
        var qt1TR = quadTree1.isLeaf ? new Node (quadTree1.val, true, null, null, null, null) : quadTree1.topRight;
        var qt1BL = quadTree1.isLeaf ? new Node (quadTree1.val, true, null, null, null, null) : quadTree1.bottomLeft;
        var qt1BR = quadTree1.isLeaf ? new Node (quadTree1.val, true, null, null, null, null) : quadTree1.bottomRight;

        var qt2TL = quadTree2.isLeaf ? new Node (quadTree2.val, true, null, null, null, null) : quadTree2.topLeft;
        var qt2TR = quadTree2.isLeaf ? new Node (quadTree2.val, true, null, null, null, null) : quadTree2.topRight;
        var qt2BL = quadTree2.isLeaf ? new Node (quadTree2.val, true, null, null, null, null) : quadTree2.bottomLeft;
        var qt2BR = quadTree2.isLeaf ? new Node (quadTree2.val, true, null, null, null, null) : quadTree2.bottomRight;

        var tl = this.Intersect (qt1TL, qt2TL);
        var tr = this.Intersect (qt1TR, qt2TR);
        var bl = this.Intersect (qt1BL, qt2BL);
        var br = this.Intersect (qt1BR, qt2BR);

        if (tl.isLeaf && tr.isLeaf && bl.isLeaf && br.isLeaf) {
            if (tl.val == tr.val && tr.val == bl.val && bl.val == br.val) {
                return new Node (tl.val, true, null, null, null, null);
            }
        }

        return new Node (value, false, tl, tr, bl, br);
    }
}