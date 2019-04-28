public class Solution {
    public int[] NumMovesStones (int a, int b, int c) {
        var z = Math.Max (a, Math.Max (b, c));
        var x = Math.Min (a, Math.Min (b, c));
        var y = a + b + c - z - x;
        var max = z - y - 1 + y - x - 1;
        var min = 2;
        if (z - y <= 2 || y - x <= 2) {
            min = 1;
        }
        if (x + 1 == y && y + 1 == z) {
            min = 0;
        }
        return new int[] { min, max };
    }
}