public class Solution {
    public IList<int> FindSubstring (string s, string[] words) {
        var res = new List<int> ();
        if (string.IsNullOrEmpty (s) || words.Length == 0) {
            return res;
        }
        var length = words[0].Length;
        var dic = new Dictionary<string, int> ();
        foreach (var word in words) {
            if (dic.ContainsKey (word)) {
                dic[word] = dic[word] + 1;
            } else {
                dic.Add (word, 1);
            }
        }
        for (int i = 0; i <= s.Length - length * words.Length; i++) {
            var copy = new Dictionary<string, int> (dic);
            for (int j = 0; j < words.Length; j++) {
                var sub = s.Substring (i + j * length, length);
                if (copy.ContainsKey (sub)) {
                    if (copy[sub] == 1) {
                        copy.Remove (sub);
                    } else {
                        copy[sub] = copy[sub] - 1;
                    }
                    if (copy.Count () == 0) {
                        res.Add (i);
                        break;
                    }
                } else {
                    break;
                }
            }
        }
        return res;
    }
}