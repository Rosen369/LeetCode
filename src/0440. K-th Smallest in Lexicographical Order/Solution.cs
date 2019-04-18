public class Solution {
    public int FindKthNumber (int n, int k) {
        var curr = 1;
        k = k - 1;
        while (k > 0) {
            var steps = CalcSteps (n, curr, curr + 1);
            if (steps <= k) {
                curr += 1;
                k -= steps;
            } else {
                curr *= 10;
                k -= 1;
            }
        }
        return curr;
    }

    public int CalcSteps (int n, long left, long right) {
        var res = 0;
        while (left <= n) {
            res += (int) (Math.Min (n + 1, right) - left);
            left *= 10;
            right *= 10;
        }
        return res;
    }
}