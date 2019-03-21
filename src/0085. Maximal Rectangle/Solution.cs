public class Solution {
    public int MaximalRectangle (char[, ] matrix) {
        var maxArea = 0;
        var row = matrix.GetLength (0);
        var col = matrix.GetLength (1);
        var heights = new int[row, col];
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                if (i != 0) {
                    heights[i, j] = heights[i - 1, j];
                }
                if (matrix[i, j] == '1') {
                    heights[i, j] = heights[i, j] + 1;
                } else {
                    heights[i, j] = 0;
                }
            }
        }
        for (int i = 0; i < row; i++) {
            var stack = new Stack<int> ();
            for (int j = 0; j <= col; j++) {
                var h = 0;
                if (j != col) {
                    h = heights[i, j];
                }
                if (stack.Count == 0 || h >= heights[i, stack.Peek ()]) {
                    stack.Push (j);
                } else {
                    int top = stack.Pop ();
                    var length = j;
                    if (stack.Count != 0) {
                        length = j - 1 - stack.Peek ();
                    }
                    maxArea = Math.Max (maxArea, heights[i, top] * length);
                    j--;
                }
            }
        }
        return maxArea;
    }
}