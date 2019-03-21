public class Solution {
    public IList<string> WordBreak (string s, IList<string> wordDict) {
        var dict = new Dictionary<string, IList<string>> ();
        DFS (s, wordDict, dict);
        return dict[s];
    }

    public void DFS (string s, IList<string> wordDict, IDictionary<string, IList<string>> dict) {
        dict.Add (s, new List<string> ());
        for (int i = 0; i < wordDict.Count (); i++) {
            var word = wordDict[i];
            if (word.Length > s.Length) {
                continue;
            }
            if (word == s) {
                dict[s].Add (s);
                continue;
            }
            var left = s.Substring (0, word.Length);
            if (left != word) {
                continue;
            }
            var right = s.Substring (word.Length);
            if (!dict.ContainsKey (right)) {
                DFS (right, wordDict, dict);
            }
            foreach (var combine in dict[right]) {
                var curr = left + " " + combine;
                dict[s].Add (curr);
            }
        }
    }
}