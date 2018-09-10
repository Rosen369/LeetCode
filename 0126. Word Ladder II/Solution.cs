public class Solution {
    public IList<IList<string>> FindLadders (string beginWord, string endWord, IList<string> wordList) {
        var res = new List<IList<string>> ();
        if (!wordList.Contains (endWord)) {
            return res;
        }
        var distance = new Dictionary<string, int> ();
        var neighbors = new Dictionary<string, IList<string>> ();
        LinkGraph (beginWord, endWord, wordList, distance, neighbors);
        FindNext (res, new List<string> (), distance, neighbors, endWord, beginWord);
        return res;
    }

    public void FindNext (IList<IList<string>> res, IList<string> path, IDictionary<string, int> distance, IDictionary<string, IList<string>> neighbors, string endWord, string currWord) {
        path.Add (currWord);
        if (currWord == endWord) {
            res.Add (new List<string> (path));
        } else {
            var currNeighbors = neighbors[currWord];
            foreach (var neighbor in currNeighbors) {
                if (distance.ContainsKey (neighbor) && distance[currWord] + 1 == distance[neighbor]) {
                    FindNext (res, path, distance, neighbors, endWord, neighbor);
                }
            }
        }
        path.RemoveAt (path.Count () - 1);
    }

    public IList<string> FindNeighbors (string word, IList<string> wordList) {
        var set = new HashSet<string> (wordList);
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

    public void LinkGraph (string startWord, string endWord, IList<string> wordList, IDictionary<string, int> distance, IDictionary<string, IList<string>> neighbors) {
        var currLevel = new HashSet<string> ();
        var nextLevel = new HashSet<string> ();
        currLevel.Add (startWord);
        var reachEnd = false;
        var level = 0;
        while (currLevel.Count () != 0) {
            nextLevel.Clear ();
            foreach (var word in currLevel) {
                if (neighbors.ContainsKey (word)) {
                    continue;
                }
                distance.Add (word, level + 1);
                if (word == endWord) {
                    neighbors.Add (word, new List<string> ());
                    reachEnd = true;
                    break;
                }
                var wordNeighbots = FindNeighbors (word, wordList);
                neighbors.Add (word, wordNeighbots);
                nextLevel.UnionWith (wordNeighbots);
            }
            if (reachEnd) {
                break;
            }
            currLevel.Clear ();
            currLevel.UnionWith (nextLevel);
            level++;
        }
    }
}