public class Solution {
    public int LastRemaining (int n) {
        if (n == 1) {
            return 1;
        }
        return 2 * (1 + n / 2 - LastRemaining (n / 2));
    }
}