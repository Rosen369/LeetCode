public class Solution {
    public bool IsRectangleCover (int[, ] rectangles) {
        var count = rectangles.GetLength (0);
        if (count == 0) {
            return false;
        }
        var x1 = int.MaxValue;
        var x2 = int.MinValue;
        var y1 = int.MaxValue;
        var y2 = int.MinValue;
        var area = 0;
        var set = new HashSet<string> ();
        for (int i = 0; i < count; i++) {
            x1 = Math.Min (x1, rectangles[i, 1]);
            x2 = Math.Max (x2, rectangles[i, 3]);
            y1 = Math.Min (y1, rectangles[i, 0]);
            y2 = Math.Max (y2, rectangles[i, 2]);

            area += (rectangles[i, 2] - rectangles[i, 0]) * (rectangles[i, 3] - rectangles[i, 1]);

            var p1 = rectangles[i, 0] + " " + rectangles[i, 1];
            var p2 = rectangles[i, 0] + " " + rectangles[i, 3];
            var p3 = rectangles[i, 2] + " " + rectangles[i, 1];
            var p4 = rectangles[i, 2] + " " + rectangles[i, 3];
            if (set.Add (p1) == false) set.Remove (p1);
            if (set.Add (p2) == false) set.Remove (p2);
            if (set.Add (p3) == false) set.Remove (p3);
            if (set.Add (p4) == false) set.Remove (p4);
        }
        if (!set.Contains (y1 + " " + x1)) {
            return false;
        }
        if (!set.Contains (y1 + " " + x2)) {
            return false;
        }
        if (!set.Contains (y2 + " " + x1)) {
            return false;
        }
        if (!set.Contains (y2 + " " + x2)) {
            return false;
        }
        if (set.Count != 4) {
            return false;
        }
        return area == (y2 - y1) * (x2 - x1);
    }
}