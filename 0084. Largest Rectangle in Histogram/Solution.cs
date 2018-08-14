public class Solution {
    public int LargestRectangleArea (int[] heights) {
        var list = new List<int> (heights);
        list.Add (0);
        heights = list.ToArray ();
        var largest = 0;
        var min = int.MaxValue;
        var index = 0;
        var length = 0;
        for (int i = 0; i < heights.Length; i++) {
            for (int j = 0; j < heights.Length; j++) {
                if (heights[j] == 0) {
                    largest = Math.Max (largest, min * length);
                    length = 0;
                    min = int.MaxValue;
                    continue;
                }
                length++;
                min = Math.Min (min, heights[j]);
                if (heights[j] != 0) {
                    if (heights[index] == 0 || heights[j] < heights[index]) {
                        index = j;
                    }
                }
            }
            heights[index] = 0;
        }
        return largest;
    }
}