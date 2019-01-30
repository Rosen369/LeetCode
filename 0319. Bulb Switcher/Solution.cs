public class Solution {
    public int BulbSwitch (int n) {
        var bulbs = new bool[n];
        for (int round = 0; round < n; round++) {
            for (int i = round; i < n; i += round + 1) {
                bulbs[i] = !bulbs[i];
            }
        }
        var count = 0;
        for (int i = 0; i < n; i++) {
            if (bulbs[i]) {
                count++;
            }
        }
        return count;
    }
}