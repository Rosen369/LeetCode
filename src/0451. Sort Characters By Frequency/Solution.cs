public class Solution1 {
    ///sort solution
    //Runtime: 104 ms
    //Memory Usage: 24.7 MB
    public string FrequencySort (string s) {
        var dict = new Dictionary<char, int> ();
        for (int i = 0; i < s.Length; i++) {
            if (!dict.ContainsKey (s[i])) {
                dict.Add (s[i], 0);
            }
            dict[s[i]]++;
        }
        var list = dict.ToList ().OrderByDescending (e => e.Value).ToList ();
        var sb = new StringBuilder ();
        for (int i = 0; i < list.Count; i++) {
            var kvp = list[i];
            for (int j = 0; j < kvp.Value; j++) {
                sb.Append (kvp.Key);
            }
        }
        return sb.ToString ();
    }
}

public class Solution2 {
    ///bucket solution
    //Runtime: 100 ms
    //Memory Usage: 26.3 MB
    public string FrequencySort (string s) {
        var dict = new Dictionary<char, int> ();
        for (int i = 0; i < s.Length; i++) {
            if (!dict.ContainsKey (s[i])) {
                dict.Add (s[i], 0);
            }
            dict[s[i]]++;
        }

        var buckets = new IList<char>[s.Length + 1];
        foreach (var pair in dict) {
            if (buckets[pair.Value] == null) {
                buckets[pair.Value] = new List<char> ();
            }
            buckets[pair.Value].Add (pair.Key);
        }

        var sb = new StringBuilder ();
        for (int i = s.Length; i >= 0; i--) {
            if (buckets[i] == null) {
                continue;
            }
            for (int j = 0; j < buckets[i].Count; j++) {
                for (int n = 0; n < i; n++) {
                    sb.Append (buckets[i][j]);
                }
            }
        }
        return sb.ToString ();
    }
}