public class Solution {
    public int ComputeArea (int A, int B, int C, int D, int E, int F, int G, int H) {
        var left = Math.Max (A, E);
        var right = Math.Max (Math.Min (C, G), left);
        var bottom = Math.Max (B, F);
        var top = Math.Max (Math.Min (D, H), bottom);
        return (C - A) * (D - B) - (right - left) * (top - bottom) + (G - E) * (H - F);
    }
}