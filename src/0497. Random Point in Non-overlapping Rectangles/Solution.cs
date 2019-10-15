public class Solution {

    public Solution (int[][] rects) {
        this._rects = rects;
        this._counts = new int[rects.Length];
        this._max = this.SetCounts ();
        this._rand = new Random ();
    }

    private int[][] _rects;

    private int[] _counts;

    private int _max;

    private Random _rand;

    public int[] Pick () {
        var r = this._rand.Next (0, this._max);
        var index = 0;
        while (r >= this._counts[index]) {
            r -= this._counts[index];
            index++;
        }
        var rect = this._rects[index];
        var width = rect[2] - rect[0] + 1;
        var row = r / width;
        var col = r % width;
        var x = rect[0] + col;
        var y = rect[1] + row;
        return new int[] { x, y };
    }

    private int SetCounts () {
        var max = 0;
        for (int i = 0; i < this._rects.Length; i++) {
            var rect = this._rects[i];
            var width = rect[2] - rect[0] + 1;
            var height = rect[3] - rect[1] + 1;
            var area = width * height;
            this._counts[i] = area;
            max += area;
        }
        return max;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(rects);
 * int[] param_1 = obj.Pick();
 */