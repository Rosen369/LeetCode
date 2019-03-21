public class Solution {
    public IList<int[]> GetSkyline (int[, ] buildings) {
        var result = new List<int[]> ();
        var height = new List<int[]> ();
        var buildingCount = buildings.GetLength (0);
        for (int i = 0; i < buildingCount; i++) {
            // start point has negative height value
            height.Add (new int[] { buildings[i, 0], -buildings[i, 2] });
            // end point has normal height value
            height.Add (new int[] { buildings[i, 1], buildings[i, 2] });
        }

        // sort $height, based on the first value, if necessary, use the second to
        // break ties
        height.Sort ((left, right) => {
            if (left[0] != right[0]) {
                return left[0] - right[0];
            }
            return left[1] - right[1];
        });

        // Use a maxHeap to store possible heights
        var pq = new PriorityQueue<int> ();

        // Provide a initial value to make it more consistent
        pq.Insert (0);

        // Before starting, the previous max height is 0;
        var prev = 0;

        // visit all points in order
        foreach (var h in height) {
            if (h[1] < 0) { // a start point, add height
                pq.Insert (-h[1]);
            } else { // a end point, remove height
                pq.Remove (h[1]);
            }
            var cur = pq.Maximum (); // current max height;

            // compare current max height with previous max height, update result and 
            // previous max height if necessary
            if (prev != cur) {
                result.Add (new int[] { h[0], cur });
                prev = cur;
            }
        }
        return result;
    }
}

public class PriorityQueue<T> where T : IComparable {

    private IList<T> _pq;

    public PriorityQueue () {
        _pq = new List<T> ();
    }

    public bool IsEmpty () {
        return _pq.Count == 0;
    }

    public T Maximum () {
        if (this.IsEmpty ()) {
            return default (T);
        }
        return _pq[0];
    }

    public T ExtractMax () {
        if (this.IsEmpty ()) {
            return default (T);
        }
        T max = _pq[0];
        Swap (0, _pq.Count - 1);
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
        Swap (index, _pq.Count - 1);
        _pq.RemoveAt (_pq.Count - 1);
        this.SiftDown (index);
    }

    public void Insert (T item) {
        _pq.Add (item);
        this.SiftUp (_pq.Count - 1);
    }

    private bool Less (int i, int j) {
        return _pq[i].CompareTo (_pq[j]) == -1;
    }

    private void SiftDown (int i) {
        int left = Left (i);
        int right = Right (i);
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
            if (Less (parent, i)) {
                Swap (parent, i);
                SiftUp (parent);
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