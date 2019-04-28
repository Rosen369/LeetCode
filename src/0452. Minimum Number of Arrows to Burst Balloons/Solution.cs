public class Solution {
    public int FindMinArrowShots (int[][] points) {
        if (points.Length == 0) {
            return 0;
        }
        points = points.OrderBy (e => e[1]).ToArray ();
        var count = 1;
        var arrow = points[0][1];
        for (int i = 1; i < points.Length; i++) {
            if (points[i][0] <= arrow) {
                continue;
            }
            arrow = points[i][1];
            count++;
        }
        return count;
    }
}