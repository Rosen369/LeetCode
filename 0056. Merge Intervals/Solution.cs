public class Solution {
    public IList<Interval> Merge (IList<Interval> intervals) {
        if (intervals.Count < 2) {
            return intervals;
        }
        intervals = intervals.OrderBy (e => e.start).ToList ();
        var res = new List<Interval> ();
        var curr = intervals[0];
        for (int i = 1; i < intervals.Count (); i++) {
            var next = intervals[i];
            if (curr.end >= next.start) {
                curr = new Interval (Math.Min (curr.start, next.start), Math.Max (curr.end, next.end));
            } else {
                res.Add (curr);
                curr = next;
            }
        }
        res.Add (curr);
        return res;
    }
}

//Definition for an interval.
public class Interval {
    public int start;
    public int end;
    public Interval () { start = 0; end = 0; }
    public Interval (int s, int e) { start = s; end = e; }
}