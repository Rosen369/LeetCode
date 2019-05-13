public class Solution {
    public int PoorPigs (int buckets, int minutesToDie, int minutesToTest) {
        var states = minutesToTest / minutesToDie + 1;
        var d = Math.Log (buckets, states);
        var c = Math.Ceiling (d);
        return Convert.ToInt32 (c);
    }
}