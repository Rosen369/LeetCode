/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class Solution {
    public int EraseOverlapIntervals (Interval[] intervals) {
        if (intervals.Length == 0) {
            return 0;
        }
        var list = new List<Interval> (intervals);
        list = list.OrderBy (e => e.end).ToList ();
        var count = 1;
        var end = list[0].end;
        for (int i = 1; i < list.Count; i++) {
            if (list[i].start >= end) {
                count++;
                end = list[i].end;
            }
        }
        return intervals.Length - count;
    }
}