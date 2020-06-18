public class Solution {

    public Solution (int[] w) {
        this._w = w;
        this._rand = new Random ();
        this.CalcCount ();
    }

    private int[] _w;

    private int _max;

    private Random _rand;

    public int PickIndex () {
        var next = this._rand.Next (0, this._max) + 1;
        var left = 0;
        var right = this._w.Length - 1;
        while (left < right) {
            var mid = left + (right - left) / 2;
            if (this._w[mid] == next) {
                return mid;
            } else if (this._w[mid] < next) {
                left = mid + 1;
            } else {
                right = mid;
            }
        }
        return left;
    }

    private void CalcCount () {
        for (int i = 1; i < this._w.Length; i++) {
            this._w[i] += this._w[i - 1];
        }
        this._max = this._w[this._w.Length - 1];
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(w);
 * int param_1 = obj.PickIndex();
 */