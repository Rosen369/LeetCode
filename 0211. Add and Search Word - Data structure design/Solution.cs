public class WordDictionary {

    private TrieNode _root;

    /** Initialize your data structure here. */
    public WordDictionary () {
        _root = new TrieNode ();
    }

    /** Adds a word into the data structure. */
    public void AddWord (string word) {
        _root.AddWord (word, 0);
    }

    /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
    public bool Search (string word) {
        return _root.Search (word, 0);
    }
}

public class TrieNode {

    private TrieNode[] _children = new TrieNode[26];

    private bool _exist = false;

    public void AddWord (string s, int i) {
        if (string.IsNullOrEmpty (s)) {
            return;
        }
        if (s.Length == i) {
            this._exist = true;
            return;
        }
        if (_children[s[i] - 'a'] == null) {
            _children[s[i] - 'a'] = new TrieNode ();
        }
        _children[s[i] - 'a'].AddWord (s, i + 1);
    }

    public bool Search (string s, int i) {
        if (string.IsNullOrEmpty (s)) {
            return false;
        }
        if (s.Length == i) {
            return this._exist;
        }
        if (s[i] == '.') {
            for (int j = 0; j < 26; j++) {
                if (this._children[j] == null) {
                    continue;
                }
                if (this._children[j].Search (s, i + 1)) {
                    return true;
                }
            }
            return false;
        }
        if (_children[s[i] - 'a'] == null) {
            return false;
        }
        return _children[s[i] - 'a'].Search (s, i + 1);
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */