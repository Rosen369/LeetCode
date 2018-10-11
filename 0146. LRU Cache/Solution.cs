public class LRUCache {
    public LRUCache (int capacity) {
        _dict = new Dictionary<int, int> ();
        _keys = new List<int> ();
        _capacity = capacity;
    }

    private IDictionary<int, int> _dict;

    private readonly IList<int> _keys;

    private readonly int _capacity;

    public int Get (int key) {
        if (_dict.ContainsKey (key)) {
            _keys.Remove (key);
            _keys.Add (key);
            return _dict[key];
        }
        return -1;
    }

    public void Put (int key, int value) {
        if (_dict.ContainsKey (key)) {
            _keys.Remove (key);
            _keys.Add (key);
            _dict[key] = value;
        } else if (_dict.Count () >= _capacity) {
            var last = _keys[0];
            _keys.RemoveAt (0);
            _keys.Add (key);
            _dict.Remove (last);
            _dict.Add (key, value);
        } else {
            _keys.Add (key);
            _dict.Add (key, value);
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */