public class Solution {
    public int LadderLength (string beginWord, string endWord, IList<string> wordList) {
        if (!wordList.Contains (endWord)) {
            return 0;
        }
        var set = new HashSet<string> (wordList);
        var res = BFS (beginWord, endWord, set);
        return res;
    }

    public IList<string> FindNeighbors (string word, HashSet<string> set) {
        var list = new List<string> ();
        var arr = word.ToCharArray ();
        for (int i = 0; i < word.Length; i++) {
            for (char c = 'a'; c <= 'z'; c++) {
                if (arr[i] == c) {
                    continue;
                }
                var oc = arr[i];
                arr[i] = c;
                var str = new string (arr);
                if (set.Contains (str)) {
                    list.Add (str);
                }
                arr[i] = oc;
            }
        }
        return list;
    }

    public int BFS (string startWord, string endWord, HashSet<string> set) {
        var visted = new HashSet<string> ();
        var currLevel = new HashSet<string> ();
        var nextLevel = new HashSet<string> ();
        currLevel.Add (startWord);
        var level = 1;
        while (currLevel.Count () != 0) {
            nextLevel.Clear ();
            foreach (var word in currLevel) {
                if (visted.Contains (word)) {
                    continue;
                }
                var neighbors = FindNeighbors (word, set);
                for (int i = 0; i < neighbors.Count (); i++) {
                    if (neighbors[i] == endWord) {
                        return level + 1;
                    }
                    nextLevel.Add (neighbors[i]);
                }
                visted.Add (word);
            }
            currLevel.Clear ();
            currLevel.UnionWith (nextLevel);
            level++;
        }
        return 0;
    }
}