public class Solution {
    public int FindMinMoves (int[] machines) {
        var total = 0;
        for (int i = 0; i < machines.Length; i++) {
            total += machines[i];
        }
        if (total % machines.Length != 0) {
            return -1;
        }
        var target = total / machines.Length;
        var max = 0;
        var count = 0;
        for (int i = 0; i < machines.Length; i++) {
            count += machines[i] - target;
            max = Math.Max (max, Math.Abs (count));
            max = Math.Max (max, machines[i] - target);
        }
        return max;
    }
}