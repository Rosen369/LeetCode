public class Solution {
    public IList<string> WordBreak (string s, IList<string> wordDict) {
        var res = new List<string> ();
        BackTrack (s, wordDict, res, new List<string> ());
        return res;
    }

    public void BackTrack (string s, IList<string> wordDict, IList<string> res, IList<string> curr) {
        if (string.IsNullOrEmpty (s)) {
            res.Add (string.Join (" ", curr.ToArray ()));
            return;
        }
        for (int i = 0; i < wordDict.Count (); i++) {
            var word = wordDict[i];
            if (word.Length > s.Length) {
                continue;
            }
            if (s.Substring (0, word.Length) == word) {
                curr.Add (word);
                BackTrack (s.Substring (word.Length), wordDict, res, curr);
                curr.RemoveAt (curr.Count () - 1);
            }
        }
    }
}