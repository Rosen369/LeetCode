public class Solution1 {
    //math solution
    //Runtime: 40 ms
    //Memory Usage: 13 MB
    public int PoorPigs (int buckets, int minutesToDie, int minutesToTest) {
        var states = minutesToTest / minutesToDie + 1;
        var d = Math.Log (buckets, states);
        var c = Math.Ceiling (d);
        return Convert.ToInt32 (c);
    }
}

public class Solution2 {
    public int PoorPigs (int buckets, int minutesToDie, int minutesToTest) {
        var baseNum = minutesToTest / minutesToDie + 1;
        var result = 1;
        var num = 0;
        while (result < buckets) {
            num++;
            result *= baseNum;
        }

        return num;
    }
}