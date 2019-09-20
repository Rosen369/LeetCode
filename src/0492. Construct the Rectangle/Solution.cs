public class Solution {
    public int[] ConstructRectangle (int area) {
        var right = (int) Math.Sqrt ((double) area);
        var left = area / right;
        while (left * right != area) {
            right--;
            left = area / right;
        }
        return new int[] { left, right };
    }
}