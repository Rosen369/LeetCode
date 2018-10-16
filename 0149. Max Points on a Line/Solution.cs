/**
 * Definition for a point.
 * public class Point {
 *     public int x;
 *     public int y;
 *     public Point() { x = 0; y = 0; }
 *     public Point(int a, int b) { x = a; y = b; }
 * }
 */
public class Solution {
    public int MaxPoints (Point[] points) {
        if (points == null) return 0;
        if (points.Length <= 2) return points.Length;

        var dict = new Dictionary<int, IDictionary<int, int>> ();
        var result = 0;
        for (int i = 0; i < points.Length; i++) {
            dict.Clear ();
            int overlap = 0, max = 0;
            for (int j = i + 1; j < points.Length; j++) {
                int x = points[j].x - points[i].x;
                int y = points[j].y - points[i].y;
                if (x == 0 && y == 0) {
                    overlap++;
                    continue;
                }
                var gcd = GenerateGCD (x, y);
                if (gcd != 0) {
                    x /= gcd;
                    y /= gcd;
                }
                if (dict.ContainsKey (x)) {
                    if (dict[x].ContainsKey (y)) {
                        dict[x][y] = dict[x][y] + 1;
                    } else {
                        dict[x].Add (y, 1);
                    }
                } else {
                    var m = new Dictionary<int, int> ();
                    m.Add (y, 1);
                    dict.Add (x, m);
                }
                max = Math.Max (max, dict[x][y]);
            }
            result = Math.Max (result, max + overlap + 1);
        }
        return result;
    }

    private int GenerateGCD (int a, int b) {
        if (b == 0) return a;
        else return GenerateGCD (b, a % b);
    }
}