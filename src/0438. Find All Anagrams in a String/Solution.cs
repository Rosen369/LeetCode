public class Solution {
    public IList<int> FindAnagrams (string s, string p) {
        var res = new List<int> ();
        if (s.Length < p.Length) {
            return res;
        }
        var count = new int[26];
        for (int i = 0; i < p.Length; i++) {
            count[p[i] - 'a']++;
        }
        var window = new int[26];
        for (int i = 0; i < p.Length - 1; i++) {
            window[s[i] - 'a']++;
        }
        for (int i = p.Length - 1; i < s.Length; i++) {
            window[s[i] - 'a']++;
            var match = true;
            for (int j = 0; j < 26; j++) {
                if (count[j] != window[j]) {
                    match = false;
                }
            }
            if (match) {
                res.Add (i - p.Length + 1);
            }
            window[s[i - p.Length + 1] - 'a']--;
        }
        return res;
    }
}