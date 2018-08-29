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
    public IList<Interval> Insert (IList<Interval> intervals, Interval newInterval) {
        var res = new List<Interval> ();
        if (intervals.Count == 0) {
            res.Add (newInterval);
            return res;
        }
        intervals = intervals.OrderBy (e => e.start).ToList ();
        for (int i = 0; i < intervals.Count (); i++) {
            var curr = intervals[i];
            if (curr.start > newInterval.end) {
                res.Add (newInterval);
                for (int j = i; j < intervals.Count (); j++) {
                    res.Add (intervals[j]);
                }
                break;
            } else {
                if (curr.end >= newInterval.start) {
                    newInterval = new Interval (Math.Min (curr.start, newInterval.start), Math.Max (curr.end, newInterval.end));
                } else {
                    res.Add (curr);
                }
                if (i == intervals.Count () - 1) {
                    res.Add (newInterval);
                }
            }
        }
        return res;
    }
}