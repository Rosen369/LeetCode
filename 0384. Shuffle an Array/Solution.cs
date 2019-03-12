public class Solution {

    public Solution (int[] nums) {
        this._nums = nums;
        this._curr = new int[nums.Length];
        this._nums.CopyTo (this._curr, 0);
        this._random = new Random ();
    }

    private int[] _nums;

    private int[] _curr;

    private Random _random;

    /** Resets the array to its original configuration and return it. */
    public int[] Reset () {
        this._nums.CopyTo (this._curr, 0);
        return this._curr;
    }

    /** Returns a random shuffling of the array. */
    public int[] Shuffle () {
        for (int i = 0; i < this._nums.Length; i++) {
            var pos = this._random.Next (i, _nums.Length);
            this.Swap (i, pos);
        }
        return this._curr;
    }

    private void Swap (int i, int j) {
        var temp = this._curr[i];
        this._curr[i] = this._curr[j];
        this._curr[j] = temp;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */