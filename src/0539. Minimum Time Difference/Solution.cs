public class Solution {
    public int FindMinDifference (IList<string> timePoints) {
        var minutes = new int[timePoints.Count];
        for (int i = 0; i < timePoints.Count; i++) {
            var p = timePoints[i];
            var h = Convert.ToInt32 (timePoints[i].Split (':') [0]);
            var m = Convert.ToInt32 (timePoints[i].Split (':') [1]);
            minutes[i] = h * 60 + m;
        }
        Array.Sort (minutes);
        var min = int.MaxValue;
        for (int i = 0; i < minutes.Length - 1; i++) {
            min = Math.Min (min, minutes[i + 1] - minutes[i]);
        }
        min = Math.Min (min, minutes[0] - minutes[minutes.Length - 1] + 1440);
        return min;
    }
}