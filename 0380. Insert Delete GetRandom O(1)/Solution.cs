public class RandomizedSet {

    /** Initialize your data structure here. */
    public RandomizedSet () {
        this._dict = new Dictionary<int, int> ();
        this._nums = new List<int> ();
        this._random = new Random ();
    }

    private IDictionary<int, int> _dict;

    private IList<int> _nums;

    private Random _random;

    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public bool Insert (int val) {
        if (this._dict.ContainsKey (val)) {
            return false;
        }
        this._nums.Add (val);
        this._dict.Add (val, this._nums.Count - 1);
        return true;
    }

    /** Removes a value from the set. Returns true if the set contained the specified element. */
    public bool Remove (int val) {
        if (!this._dict.ContainsKey (val)) {
            return false;
        }
        var len = this._nums.Count;
        var pos = this._dict[val];
        var last = this._nums[len - 1];
        this._nums[pos] = last;
        this._dict[last] = pos;
        this._nums.RemoveAt (len - 1);
        this._dict.Remove (val);
        return true;
    }

    /** Get a random element from the set. */
    public int GetRandom () {
        var count = this._dict.Count;
        var next = this._random.Next (count);
        return this._nums[next];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */