public class Solution {
    public IList<IList<int>> PalindromePairs (string[] words) {
        var res = new List<IList<int>> ();
        if (words == null || words.Length < 2) {
            return res;
        }
        var dict = new Dictionary<string, int> ();
        for (int i = 0; i < words.Length; i++) {
            dict.Add (words[i], i);
        }
        for (int i = 0; i < words.Length; i++) {
            for (int j = 0; j <= words[i].Length; j++) {
                var left = words[i].Substring (0, j);
                var right = words[i].Substring (j);
                if (IsPalindrome (left)) {
                    var reverse = Reverse (right);
                    if (dict.ContainsKey (reverse) && dict[reverse] != i) {
                        res.Add (new List<int> () { dict[reverse], i });
                    }
                }
                if (IsPalindrome (right) && right.Length != 0) {
                    var reverse = Reverse (left);
                    if (dict.ContainsKey (reverse) && dict[reverse] != i) {
                        res.Add (new List<int> () { i, dict[reverse] });
                    }
                }
            }
        }
        return res;
    }

    public bool IsPalindrome (string word) {
        var start = 0;
        var end = word.Length - 1;
        while (start < end) {
            if (word[start] != word[end]) {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }

    public string Reverse (string s) {
        char[] charArray = s.ToCharArray ();
        Array.Reverse (charArray);
        return new string (charArray);
    }
}