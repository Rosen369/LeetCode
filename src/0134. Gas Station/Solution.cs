public class Solution {
    public int CanCompleteCircuit (int[] gas, int[] cost) {
        var start = 0;
        while (start < gas.Length) {
            var fuel = 0;
            for (int curr = start; curr < start + gas.Length; curr++) {
                var pos = curr;
                if (curr >= gas.Length) {
                    pos = curr - gas.Length;
                }
                fuel += gas[pos] - cost[pos];
                if (fuel < 0) {
                    start = curr + 1;
                    break;
                }
            }
            if (fuel >= 0) {
                return start;
            }
        }
        return -1;
    }
}