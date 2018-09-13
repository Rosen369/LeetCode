public class Solution {
    public IList<IList<string>> Partition (string s) {
        var res = new List<IList<string>> ();
        if (string.IsNullOrEmpty (s)) {
            return res;
        }
        var dic = new Dictionary<string, IList<IList<string>>> ();
        var splitRes = SplitNext (s, dic);
        var set = new HashSet<string> ();
        foreach (var list in splitRes) {
            var key = string.Join ("_", list);
            if (set.Contains (key)) {
                continue;
            } else {
                res.Add (list);
                set.Add (key);
            }
        }
        return res;
    }

    public IList<IList<string>> SplitNext (string s, IDictionary<string, IList<IList<string>>> dic) {
        var res = new List<IList<string>> ();
        if (string.IsNullOrEmpty (s)) {
            return res;
        }
        if (IsPalindrome (s)) {
            res.Add (new List<string> () { s });
        }
        for (int i = 1; i <= s.Length - 1; i++) {
            var left = s.Substring (0, i);
            var right = s.Substring (i);
            var leftList = dic.ContainsKey (left) ? dic[left] : SplitNext (left, dic);
            var rightList = dic.ContainsKey (right) ? dic[right] : SplitNext (right, dic);
            foreach (var leftSub in leftList) {
                foreach (var rightSub in rightList) {
                    var combined = new List<string> ();
                    combined.AddRange (leftSub);
                    combined.AddRange (rightSub);
                    res.Add (combined);
                }
            }
        }
        if (!dic.ContainsKey (s)) {
            dic.Add (s, res);
        }
        return res;
    }

    public bool IsPalindrome (string s) {
        for (int i = 0; i < s.Length / 2; i++) {
            if (s[i] != s[s.Length - 1 - i]) {
                return false;
            }
        }
        return true;
    }
}