public class Solution {
    public IList<IList<string>> FindLadders (string beginWord, string endWord, IList<string> wordList) {
        var res = new List<IList<string>> ();
        if (!wordList.Contains (endWord)) {
            return res;
        }
        wordList.Remove (beginWord);
        var startLink = FindLinked (beginWord, wordList);
        var graph = new Dictionary<string, IList<string>> ();
        for (int i = 0; i < wordList.Count (); i++) {
            var leftList = new List<string> (wordList);
            leftList.RemoveAt (i);
            var linkList = FindLinked (wordList[i], leftList);
            graph.Add (wordList[i], linkList);
        }
        graph.Add (beginWord, startLink);
        FindNext (res, new List<string> () { beginWord }, wordList, graph, endWord, beginWord);
        if (res.Count () != 0) {
            var min = res.Min (e => e.Count ());
            res = res.Where (e => e.Count () == min).ToList ();
        }
        return res;
    }

    public void FindNext (IList<IList<string>> res, IList<string> path, IList<string> keys, IDictionary<string, IList<string>> graph, string endWord, string currWord) {
        if (res.Count () != 0) {
            var min = res.Min (e => e.Count ());
            if (path.Count () > min) {
                return;
            }
        }
        if (currWord == endWord) {
            res.Add (new List<string> (path));
            return;
        }
        var linked = graph[currWord];
        for (int i = 0; i < linked.Count (); i++) {
            if (!keys.Contains (linked[i])) {
                continue;
            }
            path.Add (linked[i]);
            keys.Remove (linked[i]);
            FindNext (res, path, keys, graph, endWord, linked[i]);
            path.Remove (linked[i]);
            keys.Add (linked[i]);
        }
    }

    public IList<string> FindLinked (string word, IList<string> wordList) {
        var list = new List<string> ();
        for (int i = 0; i < word.Length; i++) {
            for (char c = 'a'; c <= 'z'; c++) {
                var arr = word.ToCharArray ();
                arr[i] = c;
                var str = new string (arr);
                if (wordList.Contains (str)) {
                    list.Add (str);
                }
            }
        }
        return list;
    }
}