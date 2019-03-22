public class Solution {
    public bool CanCross (int[] stones) {
        if (stones[0] != 0 || stones[1] != 1) {
            return false;
        }
        var set = new HashSet<int> (stones);
        return Jump (set, 1, 1, stones[stones.Length - 1]);
    }

    private bool Jump (HashSet<int> stones, int curr, int k, int goal) {
        if (curr == goal) {
            return true;
        }
        if (k <= 0) {
            return false;
        }
        if (!stones.Contains (curr)) {
            return false;
        }
        if (Jump (stones, curr + k - 1, k - 1, goal)) {
            return true;
        }
        if (Jump (stones, curr + k, k, goal)) {
            return true;
        }
        if (Jump (stones, curr + k + 1, k + 1, goal)) {
            return true;
        }
        return false;
    }
}