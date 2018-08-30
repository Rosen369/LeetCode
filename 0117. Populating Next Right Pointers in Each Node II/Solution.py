# Definition for binary tree with next pointer.
# class TreeLinkNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None
#         self.next = None


class Solution:
    # @param root, a tree link node
    # @return nothing
    def connect(self, root):
        if not root:
            return
        curr = [root]
        next = []
        while len(curr):
            next = []
            for i, node in enumerate(curr):
                if i != len(curr) - 1:
                    node.next = curr[i + 1]
                if node.left:
                    next.append(node.left)
                if node.right:
                    next.append(node.right)
            curr = []
            curr.extend(next)
