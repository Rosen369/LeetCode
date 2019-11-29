public class Solution {
    public int FindMaximizedCapital (int k, int W, int[] profits, int[] capital) {
        var pqProfits = new PriorityQueue<Project> ((x, y) => { if (x.Profit >= y.Profit) { return true; } return false; });
        var pqCapital = new PriorityQueue<Project> ((x, y) => { if (x.Capital <= y.Capital) { return true; } return false; });
        for (int i = 0; i < profits.Length; i++) {
            pqCapital.Push (new Project { Profit = profits[i], Capital = capital[i] });
        }
        for (int i = 0; i < k; i++) {
            while (pqCapital.Count > 0 && pqCapital.Peek ().Capital <= W) {
                pqProfits.Push (pqCapital.Pop ());
            }
            if (pqProfits.Count > 0) {
                W += pqProfits.Pop ().Profit;
            }
        }
        return W;
    }

    private class Project {
        public int Profit { get; set; }

        public int Capital { get; set; }
    }

    private class PriorityQueue<T> {
        public PriorityQueue (Func<T, T, bool> compFunc) {
            this._pq = new List<T> ();
            this._compFunc = compFunc;
        }

        private Func<T, T, bool> _compFunc;

        private IList<T> _pq;

        public int Count {
            get {
                return this._pq.Count;
            }
        }

        public T Pop () {
            var top = this._pq[0];
            var last = this.Count - 1;
            this.Swap (0, last);
            this._pq.RemoveAt (last);
            this.SiftDown (0);
            return top;
        }

        public T Peek () {
            var top = this._pq[0];
            return top;
        }

        public void Push (T n) {
            this._pq.Add (n);
            this.SiftUp (this._pq.Count - 1);
        }

        private int Parent (int x) {
            return (x - 1) / 2;
        }

        private int Left (int x) {
            return x * 2 + 1;
        }

        private int Right (int x) {
            return x * 2 + 2;
        }

        private void SiftDown (int x) {
            var left = this.Left (x);
            var right = this.Right (x);
            var largest = x;
            if (left < this._pq.Count && !this.Compare (largest, left)) {
                largest = left;
            }
            if (right < this._pq.Count && !this.Compare (largest, right)) {
                largest = right;
            }
            if (largest != x) {
                this.Swap (x, largest);
                this.SiftDown (largest);
            }
        }

        private void SiftUp (int x) {
            if (x == 0) { return; }
            var p = this.Parent (x);
            if (this.Compare (x, p)) {
                this.Swap (x, p);
                this.SiftUp (p);
            }
        }

        private void Swap (int x, int y) {
            if (x == y) { return; }
            var temp = this._pq[x];
            this._pq[x] = this._pq[y];
            this._pq[y] = temp;
        }

        private bool Compare (int x, int y) {
            return this._compFunc (this._pq[x], this._pq[y]);
        }
    }
}