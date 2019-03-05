public class Solution {
    public IList<int[]> KSmallestPairs (int[] nums1, int[] nums2, int k) {
        var res = new List<int[]> ();
        if (nums1.Length == 0 || nums2.Length == 0 || k == 0) {
            return res;
        }
        var pq = new MinHeap ();
        for (int i = 0; i < nums1.Length; i++) {
            for (int j = 0; j < nums2.Length; j++) {
                pq.Push (new int[] { nums1[i], nums2[j] });
            }
        }
        while (!pq.IsEmpty () && res.Count < k) {
            res.Add (pq.Pop ());
        }
        return res;
    }

    public class MinHeap {

        public MinHeap () {
            this._heap = new List<int[]> ();
        }

        public IList<int[]> _heap;

        public int[] Pop () {
            if (this._heap.Count == 0) {
                return null;
            }
            var max = this._heap[0];
            this.Swap (0, this._heap.Count - 1);
            this._heap.RemoveAt (this._heap.Count - 1);
            this.SiftDown (0);
            return max;
        }

        public void Push (int[] item) {
            this._heap.Add (item);
            this.SiftUp (this._heap.Count - 1);
        }

        public bool IsEmpty () {
            return _heap.Count == 0;
        }

        private void SiftDown (int i) {
            var left = this.Left (i);
            var right = this.Right (i);
            var largest = i;
            if (left <= this._heap.Count - 1 && this.Greater (largest, left)) {
                largest = left;
            }
            if (right <= this._heap.Count - 1 && this.Greater (largest, right)) {
                largest = right;
            }
            if (largest != i) {
                this.Swap (largest, i);
                this.SiftDown (largest);
            }
        }

        private void SiftUp (int i) {
            if (i > 0) {
                var parent = this.Parent (i);
                if (this.Greater (parent, i)) {
                    this.Swap (i, parent);
                    this.SiftUp (parent);
                }
            }
        }

        private int Left (int i) {
            return 2 * i + 1;
        }

        private int Right (int i) {
            return 2 * i + 2;
        }

        private int Parent (int i) {
            return (i - 1) / 2;
        }

        private bool Greater (int i, int j) {
            var sum1 = this._heap[i][0] + this._heap[i][1];
            var sum2 = this._heap[j][0] + this._heap[j][1];
            return sum1 > sum2;
        }

        private void Swap (int i, int j) {
            var temp = this._heap[i];
            this._heap[i] = this._heap[j];
            this._heap[j] = temp;
        }
    }
}