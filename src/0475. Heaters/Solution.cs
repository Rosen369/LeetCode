public class Solution {
    public int FindRadius (int[] houses, int[] heaters) {
        Array.Sort (houses);
        Array.Sort (heaters);
        var radius = 0;
        var n = 0;
        for (int i = 0; i < houses.Length; i++) {
            var house = houses[i];
            var least = int.MaxValue;
            for (int j = n; j < heaters.Length; j++) {
                var heater = heaters[j];
                var abs = Math.Abs (house - heater);
                if (abs <= least) {
                    least = abs;
                    n = j;
                } else {
                    break;
                }
            }
            radius = Math.Max (least, radius);
        }
        return radius;
    }
}