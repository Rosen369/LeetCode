public class Solution {
    public int KthSmallest (int[, ] matrix, int k) {
        var n = matrix.GetLength (0);
        var heap = new MinHeap ();
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                heap.Push (matrix[i, j]);
            }
        }
        for (int i = 0; i < k - 1; i++) {
            heap.Pop ();
        }
        return heap.Pop ();
    }

    private class MinHeap {
        public MinHeap () {
            this._heap = new List<int> ();
        }

        private IList<int> _heap;

        public bool IsEmpty () {
            return this._heap.Count == 0;
        }

        public int Count () {
            return this._heap.Count;
        }

        public int Pop () {
            var max = this._heap[0];
            this.Swap (0, this._heap.Count - 1);
            this._heap.RemoveAt (this._heap.Count - 1);
            this.SiftDown (0);
            return max;
        }

        public void Push (int n) {
            this._heap.Add (n);
            this.SiftUp (this._heap.Count - 1);
        }

        private void SiftDown (int i) {
            var largest = i;
            var left = this.Left (i);
            if (left <= this._heap.Count - 1 && this.Greater (i, left)) {
                largest = left;
            }
            var right = this.Right (i);
            if (right <= this._heap.Count - 1 && this.Greater (largest, right)) {
                largest = right;
            }
            if (largest != i) {
                this.Swap (largest, i);
                this.SiftDown (largest);
            }
        }

        private void SiftUp (int i) {
            var parent = this.Parent (i);
            if (this.Greater (parent, i)) {
                this.Swap (parent, i);
                this.SiftUp (parent);
            }
        }

        private bool Greater (int i, int j) {
            return this._heap[i] > this._heap[j];
        }

        private void Swap (int i, int j) {
            var temp = this._heap[i];
            this._heap[i] = this._heap[j];
            this._heap[j] = temp;
        }

        private int Left (int i) {
            return i * 2 + 1;
        }

        private int Right (int i) {
            return i * 2 + 2;
        }

        private int Parent (int i) {
            return (i - 1) / 2;
        }
    }
}