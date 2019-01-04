public class MedianFinder {

    /** initialize your data structure here. */
    public MedianFinder () {
        low = new PriorityQueue<int> (true);
        high = new PriorityQueue<int> (false);
    }

    private PriorityQueue<int> low;

    private PriorityQueue<int> high;

    public void AddNum (int num) {
        low.Add (num);
        high.Add (low.Pop ());
        if (low.Count () < high.Count ()) {
            low.Add (high.Pop ());
        }
    }

    public double FindMedian () {
        if (low.Count () > high.Count ()) {
            return (double) low.Peek ();
        } else {
            return (low.Peek () + high.Peek ()) / 2.0;
        }
    }
}

public class PriorityQueue<T> where T : IComparable {

    private IList<T> _pq;

    private bool _max;

    public PriorityQueue (bool max) {
        _pq = new List<T> ();
        this._max = max;
    }

    public bool IsEmpty () {
        return _pq.Count == 0;
    }

    public T Peek () {
        if (this.IsEmpty ()) {
            return default (T);
        }
        return _pq[0];
    }

    public T Pop () {
        if (this.IsEmpty ()) {
            return default (T);
        }
        T max = _pq[0];
        this.Swap (0, _pq.Count - 1);
        _pq.RemoveAt (_pq.Count - 1);
        this.SiftDown (0);
        return max;
    }

    public void Remove (T item) {
        if (this.IsEmpty ()) {
            return;
        }
        var index = _pq.IndexOf (item);
        if (index == -1) {
            return;
        }
        this.Swap (index, _pq.Count - 1);
        _pq.RemoveAt (_pq.Count - 1);
        this.SiftDown (index);
    }

    public void Add (T item) {
        _pq.Add (item);
        this.SiftUp (_pq.Count - 1);
    }

    public int Count () {
        return this._pq.Count;
    }

    private bool Less (int i, int j) {
        if (_max) {
            return _pq[i].CompareTo (_pq[j]) == -1;
        } else {
            return _pq[i].CompareTo (_pq[j]) == 1;
        }
    }

    private void SiftDown (int i) {
        int left = this.Left (i);
        int right = this.Right (i);
        int largest = i;
        if (left <= _pq.Count - 1 && this.Less (i, left))
            largest = left;
        if (right <= _pq.Count - 1 && this.Less (largest, right))
            largest = right;
        if (largest != i) {
            this.Swap (i, largest);
            this.SiftDown (largest);
        }
    }

    private void SiftUp (int i) {
        if (i > 0) {
            var parent = Parent (i);
            if (this.Less (parent, i)) {
                this.Swap (parent, i);
                this.SiftUp (parent);
            }
        }
    }

    private void Swap (int i, int j) {
        T t = _pq[i];
        _pq[i] = _pq[j];
        _pq[j] = t;
    }

    private int Parent (int i) {
        return (i - 1) / 2;
    }

    private int Left (int i) {
        return 2 * i + 1;
    }

    private int Right (int i) {
        return 2 * i + 2;
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */