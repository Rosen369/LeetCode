public class Solution {
    public IList<string> FindAllConcatenatedWordsInADict (string[] words) {
        var root = new Trie ();
        for (int i = 0; i < words.Length; i++) {
            root.Add (words[i], 0);
        }
        var res = new List<string> ();
        for (int i = 0; i < words.Length; i++) {
            if (WordCombineInTrie (words[i], root, root, 0)) {
                res.Add (words[i]);
            }
        }
        return res;
    }

    private bool WordCombineInTrie (string word, Trie root, Trie node, int index) {
        if (node.Word == word) return false;
        if (word.Length == index) {
            if (string.IsNullOrEmpty (node.Word)) {
                return false;
            } else {
                return true;
            }
        }
        var pos = word[index] - 'a';
        var child = node.Children[pos];
        if (child == null) return false;
        var childWord = child.Word;
        if (WordCombineInTrie (word, root, child, index + 1)) {
            return true;
        }
        if (!string.IsNullOrEmpty (childWord)) {
            if (WordCombineInTrie (word, root, root, index + 1)) {
                return true;
            }
        }
        return false;
    }

    private class Trie {
        public Trie () {
            this.Children = new Trie[26];
        }

        public string Word { get; set; }

        public Trie[] Children { get; set; }

        public void Add (string word, int index) {
            if (string.IsNullOrEmpty (word)) return;
            if (word.Length == index) {
                this.Word = word;
                return;
            }
            var pos = word[index] - 'a';
            if (this.Children[pos] == null) {
                this.Children[pos] = new Trie ();
            }
            this.Children[pos].Add (word, index + 1);
        }
    }
}