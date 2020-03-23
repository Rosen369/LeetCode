public class Solution {
    public int FindRotateSteps (string ring, string key) {
        var dict = new Dictionary<string, int> ();
        return DFS (ring, key, 0, dict);
    }

    private int DFS (string ring, string key, int index, IDictionary<string, int> dict) {
        if (key.Length == index) {
            return 0;
        }
        var hashKey = ring + index;
        if (dict.ContainsKey (hashKey)) {
            return dict[hashKey];
        }
        var minSteps = int.MaxValue;

        var c = key[index];

        for (int i = 0; i < ring.Length; i++) {
            if (ring[i] == c) {
                var steps = 1 + Math.Min (i, ring.Length - i);
                var next = ring.Substring (i) + ring.Substring (0, i);
                steps += this.DFS (next, key, index + 1, dict);
                minSteps = Math.Min (steps, minSteps);
            }
        }

        dict.Add (hashKey, minSteps);
        return minSteps;
    }
}