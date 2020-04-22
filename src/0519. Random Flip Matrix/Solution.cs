public class Solution {

    public Solution (int n_rows, int n_cols) {
        this._rows = n_rows;
        this._cols = n_cols;
        this._occupied = new HashSet<int> ();
        this._rand = new Random ();
        this._total = n_rows * n_cols;
    }

    private int _rows;

    private int _cols;

    private int _total;

    private HashSet<int> _occupied;

    private Random _rand;

    public int[] Flip () {
        var max = this._total - this._occupied.Count ();
        var next = this._rand.Next (0, max);
        while (this._occupied.Contains (next)) {
            next++;
        }
        this._occupied.Add (next);
        var res = new int[2];
        res[0] = next / this._cols;
        res[1] = next % this._cols;
        return res;
    }

    public void Reset () {
        this._occupied = new HashSet<int> ();
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(n_rows, n_cols);
 * int[] param_1 = obj.Flip();
 * obj.Reset();
 */