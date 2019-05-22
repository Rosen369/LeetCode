public class LFUCache {
    public LFUCache (int capacity) {
        _capacity = capacity;
        _key_freq = new Dictionary<int, int> ();
        _key_value = new Dictionary<int, int> ();
        _freq = new SortedSet<int> ();
        _freq_key = new Dictionary<int, OrderedSet<int>> ();
        _freq_key.Add (1, new OrderedSet<int> ());
    }

    private int _capacity;

    private IDictionary<int, int> _key_freq;

    private IDictionary<int, int> _key_value;

    private IDictionary<int, OrderedSet<int>> _freq_key;

    private SortedSet<int> _freq;

    public int Get (int key) {
        if (!_key_value.ContainsKey (key)) {
            return -1;
        }
        var value = _key_value[key];
        var freq = _key_freq[key];
        _freq_key[freq].Remove (key);
        _key_freq[key]++;
        if (!_freq_key.ContainsKey (freq + 1)) {
            _freq_key.Add (freq + 1, new OrderedSet<int> ());
        }
        _freq_key[freq + 1].Add (key);
        if (_freq_key[freq].Count == 0) {
            _freq.Remove (freq);
        }
        _freq.Add (freq + 1);
        return value;
    }

    public void Put (int key, int value) {
        if (_capacity <= 0) return;
        if (_key_value.ContainsKey (key)) {
            _key_value[key] = value;
            Get (key);
        } else {
            if (_key_value.Keys.Count == _capacity) {
                var leastFreq = _freq.First ();
                if (_freq_key[leastFreq].Count == 0) {
                    _freq.Remove (leastFreq);
                }
                var leastKey = _freq_key[leastFreq].First ();
                _freq_key[leastFreq].Remove (leastKey);
                _key_freq.Remove (leastKey);
                _key_value.Remove (leastKey);
            }
            _key_freq.Add (key, 1);
            _key_value.Add (key, value);
            _freq.Add (1);
            _freq_key[1].Add (key);
        }
    }
}

public class OrderedSet<T> : ICollection<T> {
    private readonly IDictionary<T, LinkedListNode<T>> m_Dictionary;

    private readonly LinkedList<T> m_LinkedList;

    public OrderedSet () : this (EqualityComparer<T>.Default) { }

    public OrderedSet (IEqualityComparer<T> comparer) {
        m_Dictionary = new Dictionary<T, LinkedListNode<T>> (comparer);
        m_LinkedList = new LinkedList<T> ();
    }

    public int Count {
        get { return m_Dictionary.Count; }
    }

    public virtual bool IsReadOnly {
        get { return m_Dictionary.IsReadOnly; }
    }

    void ICollection<T>.Add (T item) {
        Add (item);
    }

    public bool Add (T item) {
        if (m_Dictionary.ContainsKey (item)) return false;
        LinkedListNode<T> node = m_LinkedList.AddLast (item);
        m_Dictionary.Add (item, node);
        return true;
    }

    public void Clear () {
        m_LinkedList.Clear ();
        m_Dictionary.Clear ();
    }

    public bool Remove (T item) {
        LinkedListNode<T> node;
        bool found = m_Dictionary.TryGetValue (item, out node);
        if (!found) return false;
        m_Dictionary.Remove (item);
        m_LinkedList.Remove (node);
        return true;
    }

    public IEnumerator<T> GetEnumerator () {
        return m_LinkedList.GetEnumerator ();
    }

    IEnumerator IEnumerable.GetEnumerator () {
        return GetEnumerator ();
    }

    public bool Contains (T item) {
        return m_Dictionary.ContainsKey (item);
    }

    public void CopyTo (T[] array, int arrayIndex) {
        m_LinkedList.CopyTo (array, arrayIndex);
    }
}

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */