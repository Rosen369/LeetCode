public class Solution {
    public IList<IList<int>> PalindromePairs (string[] words) {
        var res = new List<IList<int>> ();
        for (int i = 0; i < words.Length; i++) {
            for (int j = 0; j < words.Length; j++) {
                if (i == j) {
                    continue;
                }
                if (IsPalindrome (words[i] + words[j])) {
                    res.Add (new List<int> () { i, j });
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
}