/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class SummaryRanges {

    /** Initialize your data structure here. */
    public SummaryRanges () {
        this._list = new SortedList ();
    }

    private SortedList _list;

    public void AddNum (int val) {
        if (!this._list.ContainsKey (val)) {
            this._list.Add (val, new Interval (val, val));
        }
    }

    public IList<Interval> GetIntervals () {
        var res = new List<Interval> ();
        if (this._list.Count == 0) {
            return res;
        }
        var pre = this._list.GetByIndex (0) as Interval;
        var index = 1;
        while (index < this._list.Count) {
            var curr = this._list.GetByIndex (index) as Interval;
            if (curr != null) {
                if (pre.end + 1 == curr.start) {
                    pre.end = curr.end;
                    this._list[curr.start] = null;
                } else {
                    res.Add (pre);
                    pre = curr;
                }
            }
            index++;
        }
        res.Add (pre);
        return res;
    }
}

/**
 * Your SummaryRanges object will be instantiated and called as such:
 * SummaryRanges obj = new SummaryRanges();
 * obj.AddNum(val);
 * IList<Interval> param_2 = obj.GetIntervals();
 */