/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class Solution1 {
    //dict solution
    //Runtime: 632 ms
    //Memory Usage: 45.4 MB
    public int[] FindRightInterval (Interval[] intervals) {
        var res = new int[intervals.Length];
        var dict = new Dictionary<int, int> ();
        var max = int.MinValue;
        for (int i = 0; i < intervals.Length; i++) {
            max = Math.Max (max, intervals[i].start);
            dict.Add (intervals[i].start, i);
        }
        for (int i = 0; i < intervals.Length; i++) {
            var end = intervals[i].end;
            if (end > max) {
                res[i] = -1;
            } else {
                while (!dict.ContainsKey (end)) {
                    end++;
                }
                res[i] = dict[end];
                for (int j = end; j >= intervals[i].end; j--) {
                    if (!dict.ContainsKey (j)) {
                        dict.Add (j, res[i]);
                    }
                }
            }
        }
        return res;
    }
}

public class Solution2 {
    //binary search solution
    //Runtime: 616 ms
    //Memory Usage: 45.8 MB
    public int[] FindRightInterval (Interval[] intervals) {
        var res = new int[intervals.Length];
        var dict = new Dictionary<int, int> ();
        var max = int.MinValue;
        for (int i = 0; i < intervals.Length; i++) {
            max = Math.Max (max, intervals[i].start);
            dict.Add (intervals[i].start, i);
        }
        var list = dict.Keys.ToList ();
        list.Sort ();
        for (int i = 0; i < intervals.Length; i++) {
            var end = intervals[i].end;
            if (end > max) {
                res[i] = -1;
            } else {
                var left = 0;
                var right = list.Count - 1;
                while (left < right) {
                    var mid = (left + right) / 2;
                    if (list[mid] < end) {
                        left = mid + 1;
                    } else {
                        right = mid;
                    }
                }
                res[i] = dict[list[left]];
            }
        }
        return res;
    }
}