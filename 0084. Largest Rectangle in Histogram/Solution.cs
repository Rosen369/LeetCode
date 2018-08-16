public class Solution {
    public int LargestRectangleArea (int[] heights) {
        var len = heights.Length;
        var stack = new Stack<int> ();
        var maxArea = 0;
        for (int i = 0; i <= len; i++) {
            var h = 0;
            if (i != len) {
                h = heights[i];
            }
            if (stack.Count == 0 || h >= heights[stack.Peek ()]) {
                stack.Push (i);
            } else {
                int top = stack.Pop ();
                var length = i;
                if (stack.Count != 0) {
                    length = i - 1 - stack.Peek ();
                }
                maxArea = Math.Max (maxArea, heights[top] * length);
                i--;
            }
        }
        return maxArea;
    }
}