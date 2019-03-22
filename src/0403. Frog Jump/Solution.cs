public class Solution {
    public bool CanCross (int[] stones) {
        if (stones[0] != 0 || stones[1] != 1) {
            return false;
        }
        // record impassable jump on stone n with k steps
        var dict = new Dictionary<int, HashSet<int>> ();
        for (int i = 0; i < stones.Length; i++) {
            dict.Add (stones[i], new HashSet<int> (0));
        }
        return Jump (dict, 1, 1, stones[stones.Length - 1]);
    }

    private bool Jump (IDictionary<int, HashSet<int>> dict, int curr, int k, int goal) {
        if (curr == goal) {
            return true;
        }
        if (k <= 0 || !dict.ContainsKey (curr) || dict[curr].Contains (k)) {
            return false;
        }
        if (Jump (dict, curr + k - 1, k - 1, goal)) {
            return true;
        }
        if (Jump (dict, curr + k, k, goal)) {
            return true;
        }
        if (Jump (dict, curr + k + 1, k + 1, goal)) {
            return true;
        }
        dict[curr].Add (k);
        return false;
    }
}