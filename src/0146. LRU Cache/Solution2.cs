public class LRUCache {
    //double linked list solution
    //Runtime: 264 ms
    //Memory Usage: 47.9 MB
    public LRUCache (int capacity) {
        this._cap = capacity;
        this._head = new Node (-1, -1);
        this._tail = new Node (-1, -1);
        this._head.Next = this._tail;
        this._tail.Pre = this._head;
        this._dict = new Dictionary<int, Node> ();
    }

    private int _cap;

    private Node _head;

    private Node _tail;

    private IDictionary<int, Node> _dict;

    public int Get (int key) {
        if (this._dict.ContainsKey (key)) {
            var node = this._dict[key];
            this.BringToFront (node);
            return node.Value;
        }
        return -1;
    }

    public void Put (int key, int value) {
        if (this._dict.ContainsKey (key)) {
            var node = this._dict[key];
            node.Value = value;
            this.BringToFront (node);
        } else {
            var node = new Node (key, value);
            this._dict.Add (key, node);
            this.BringToFront (node);
        }
        if (this._dict.Keys.Count > this._cap) {
            var last = this._tail.Pre;
            this._tail.Pre = this._tail.Pre.Pre;
            this._tail.Pre.Next = this._tail;
            this._dict.Remove (last.Key);
        }
    }

    private void BringToFront (Node node) {
        var pre = node.Pre;
        var next = node.Next;
        if (pre != null) pre.Next = next;
        if (next != null) next.Pre = pre;
        var headNext = this._head.Next;
        this._head.Next = node;
        headNext.Pre = node;
        node.Pre = this._head;
        node.Next = headNext;
    }

    private class Node {
        public Node (int key, int val) {
            this.Key = key;
            this.Value = val;
        }

        public int Key { get; set; }

        public int Value { get; set; }

        public Node Pre { get; set; }

        public Node Next { get; set; }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */