public class Solution {
    public string FindLongestWord (string s, IList<string> d) {
        var res = string.Empty;
        var dict = new Dictionary<char, IList<int>> ();
        for (int i = 0; i < s.Length; i++) {
            if (!dict.ContainsKey (s[i])) {
                dict[s[i]] = new List<int> ();
            }
            dict[s[i]].Add (i);
        }
        for (int i = 0; i < d.Count; i++) {
            var w = d[i];
            if (w.Length < res.Length) {
                continue;
            }
            if (this.CanForm (dict, w)) {
                if (res.Length == w.Length) {
                    res = this.Less (w, res) ? w : res;
                } else {
                    res = w;
                }
            }
        }
        return res;
    }

    private bool CanForm (IDictionary<char, IList<int>> dict, string word) {
        var pos = -1;
        for (int i = 0; i < word.Length; i++) {
            if (dict.ContainsKey (word[i])) {
                var list = dict[word[i]];
                var hasBigger = false;
                for (int j = 0; j < list.Count; j++) {
                    if (list[j] > pos) {
                        hasBigger = true;
                        pos = list[j];
                        break;
                    }
                }
                if (!hasBigger) {
                    return false;
                }
            } else {
                return false;
            }
        }
        return true;
    }

    private bool Less (string a, string b) {
        for (int i = 0; i < a.Length; i++) {
            if (a[i] == b[i]) {
                continue;
            }
            if (a[i] < b[i]) {
                return true;
            } else {
                return false;
            }
        }
        return true;
    }
}