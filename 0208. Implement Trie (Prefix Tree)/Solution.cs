public class Trie {

    /** Initialize your data structure here. */
    public Trie () {
        _children = new Dictionary<char, Trie> ();
    }

    private IDictionary<char, Trie> _children;

    private bool _exist = false;

    /** Inserts a word into the trie. */
    public void Insert (string word) {
        if (string.IsNullOrEmpty (word)) {
            this._exist = true;
            return;
        }
        if (_children.ContainsKey (word[0])) {
            _children[word[0]].Insert (word.Substring (1));
        } else {
            var child = new Trie ();
            child.Insert (word.Substring (1));
            _children.Add (word[0], child);
        }
    }

    /** Returns if the word is in the trie. */
    public bool Search (string word) {
        if (string.IsNullOrEmpty (word)) {
            return this._exist;
        }
        if (!_children.ContainsKey (word[0])) {
            return false;
        } else {
            return _children[word[0]].Search (word.Substring (1));
        }
    }

    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith (string prefix) {
        if (string.IsNullOrEmpty (prefix)) {
            return true;
        }
        if (!_children.ContainsKey (prefix[0])) {
            return false;
        }
        return _children[prefix[0]].StartsWith (prefix.Substring (1));
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */