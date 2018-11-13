public class Solution {
    public IList<string> FindWords (char[, ] board, string[] words) {
        var res = new HashSet<string> ();
        var trie = BuildTrie (words);
        var row = board.GetLength (0);
        var column = board.GetLength (1);
        for (int i = 0; i < column; i++) {
            for (int j = 0; j < row; j++) {
                DFS (board, i, j, trie, res);
            }
        }
        return res.ToList ();
    }

    public Trie BuildTrie (string[] words) {
        var root = new Trie ();
        for (int i = 0; i < words.Length; i++) {
            var curr = root;
            var word = words[i];
            for (int j = 0; j < word.Length; j++) {
                if (curr.Children[word[j] - 'a'] == null) {
                    curr.Children[word[j] - 'a'] = new Trie ();
                }
                curr = curr.Children[word[j] - 'a'];
            }
            curr.Word = word;
        }
        return root;
    }

    public void DFS (char[, ] board, int x, int y, Trie trie, HashSet<string> res) {
        if (!string.IsNullOrEmpty (trie.Word)) {
            res.Add (trie.Word);
        }
        if (x < 0 || x >= board.GetLength (1)) {
            return;
        }
        if (y < 0 || y >= board.GetLength (0)) {
            return;
        }
        var curr = board[y, x];
        if (curr == '#') {
            return;
        }
        var child = trie.Children[curr - 'a'];
        if (child != null) {
            board[y, x] = '#';
            DFS (board, x - 1, y, child, res);
            DFS (board, x + 1, y, child, res);
            DFS (board, x, y - 1, child, res);
            DFS (board, x, y + 1, child, res);
            board[y, x] = curr;
        }
    }
}

public class Trie {

    public Trie[] Children = new Trie[26];

    public string Word = string.Empty;
}