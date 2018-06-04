public class Solution {
    public IList<int> FindSubstring (string s, string[] words) {
        var res = new List<int> ();
        if (words.Length == 0) {
            return res;
        }
        for (int i = 0; i < s.Length; i++) {
            if (MatchNextWord (s.Substring (i), words.ToList ())) {
                res.Add (i);
            }
        }
        return res;
    }

    public bool MatchNextWord (string s, IList<string> words) {
        if (words.Count () == 0) {
            return true;
        }
        for (int i = 0; i < words.Count (); i++) {
            if (words.Count () == 1 && s == words[i]) {
                return true;
            }
            if (s.Length < words[i].Length) {
                continue;
            }
            var match = s.Substring (0, words[i].Length) == words[i];
            if (match) {
                var sub = s.Substring (words[i].Length);
                words.RemoveAt (i);
                return MatchNextWord (sub, words);
            }
        }
        return false;
    }
}