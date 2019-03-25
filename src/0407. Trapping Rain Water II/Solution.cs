public class Solution {
    public int TrapRainWater (int[, ] heightMap) {
        var minHeap = new MinHeap ();
        var m = heightMap.GetLength (0);
        var n = heightMap.GetLength (1);
        var visited = new bool[m, n];
        //add border into heap
        for (int i = 0; i < m; i++) {
            visited[i, 0] = true;
            visited[i, n - 1] = true;
            minHeap.Add (new Cell (i, 0, heightMap[i, 0]));
            minHeap.Add (new Cell (i, n - 1, heightMap[i, n - 1]));
        }
        for (int i = 1; i < n - 1; i++) {
            visited[0, i] = true;
            visited[m - 1, i] = true;
            minHeap.Add (new Cell (0, i, heightMap[0, i]));
            minHeap.Add (new Cell (m - 1, i, heightMap[m - 1, i]));
        }

        var directions = new int[, ] { {-1, 0 }, { 1, 0 }, { 0, -1 }, { 0, 1 } };
        var res = 0;
        while (!minHeap.IsEmpty ()) {
            var cell = minHeap.Pop ();
            for (int i = 0; i < 4; i++) {
                var row = cell.Row + directions[i, 0];
                var col = cell.Col + directions[i, 1];
                if (row < 0 || row >= m || col < 0 || col >= n || visited[row, col]) {
                    continue;
                }
                visited[row, col] = true;
                res += Math.Max (0, cell.Height - heightMap[row, col]);
                minHeap.Add (new Cell (row, col, Math.Max (heightMap[row, col], cell.Height)));
            }
        }
        return res;
    }

    private class Cell {
        public Cell (int row, int col, int height) {
            this.Row = row;
            this.Col = col;
            this.Height = height;
        }

        public int Row { get; private set; }

        public int Col { get; private set; }

        public int Height { get; private set; }
    }

    private class MinHeap {

        private IList<Cell> _pq;

        public MinHeap () {
            _pq = new List<Cell> ();
        }

        public bool IsEmpty () {
            return _pq.Count == 0;
        }

        public Cell Peek () {
            if (this.IsEmpty ()) {
                return null;
            }
            return _pq[0];
        }

        public Cell Pop () {
            if (this.IsEmpty ()) {
                return null;
            }
            var max = _pq[0];
            this.Swap (0, _pq.Count - 1);
            _pq.RemoveAt (_pq.Count - 1);
            this.SiftDown (0);
            return max;
        }

        public void Remove (Cell item) {
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

        public void Add (Cell item) {
            _pq.Add (item);
            this.SiftUp (_pq.Count - 1);
        }

        private bool Greater (int i, int j) {
            if (_pq[i].Height - _pq[j].Height > 0) {
                return true;
            }
            return false;
        }

        private void SiftDown (int i) {
            int left = this.Left (i);
            int right = this.Right (i);
            int largest = i;
            if (left <= _pq.Count - 1 && this.Greater (i, left))
                largest = left;
            if (right <= _pq.Count - 1 && this.Greater (largest, right))
                largest = right;
            if (largest != i) {
                this.Swap (i, largest);
                this.SiftDown (largest);
            }
        }

        private void SiftUp (int i) {
            if (i > 0) {
                var parent = Parent (i);
                if (this.Greater (parent, i)) {
                    this.Swap (parent, i);
                    this.SiftUp (parent);
                }
            }
        }

        private void Swap (int i, int j) {
            var t = _pq[i];
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
}