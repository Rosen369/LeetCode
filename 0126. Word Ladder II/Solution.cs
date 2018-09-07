public class Solution {
    public IList<IList<string>> FindLadders (string beginWord, string endWord, IList<string> wordList) {
        if (!wordList.Contains (endWord)) {
            return new List<IList<string>> ();
        }
        var res = FindNext (beginWord, endWord, wordList);
        if (res.Count () == 0) {
            return res;
        }
        var minLength = res.Min (e => e.Count ());
        res = res.Where (e => e.Count () == minLength).ToList ();
        return res;
    }

    public IList<IList<string>> FindNext (string beginWord, string endWord, IList<string> wordList) {
        var res = new List<IList<string>> ();
        if (beginWord == endWord) {
            res.Add (new List<string> () { endWord });
            return res;
        }
        for (int i = 0; i < wordList.Count (); i++) {
            var word = wordList[i];
            var dif = 0;
            for (int j = 0; j < beginWord.Length; j++) {
                if (beginWord[j] != word[j]) {
                    dif++;
                }
            }
            if (dif == 1) {
                wordList.RemoveAt (i);
                var nextStep = FindNext (word, endWord, wordList);
                wordList.Insert (i, word);
                if (nextStep.Count () != 0) {
                    foreach (var ladder in nextStep) {
                        ladder.Insert (0, beginWord);
                        res.Add (ladder);
                    }
                }
            }
        }
        return res;
    }
}