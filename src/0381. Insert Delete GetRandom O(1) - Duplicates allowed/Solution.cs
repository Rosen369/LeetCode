public class RandomizedCollection {

    /** Initialize your data structure here. */
    public RandomizedCollection () {
        this._dict = new Dictionary<int, HashSet<int>> ();
        this._nums = new List<int> ();
        this._random = new Random ();
    }

    private IDictionary<int, HashSet<int>> _dict;

    private IList<int> _nums;

    private Random _random;

    /** Inserts a value to the collection. Returns true if the collection did not already contain the specified element. */
    public bool Insert (int val) {
        var contains = this._dict.ContainsKey (val);
        if (!contains) {
            this._dict.Add (val, new HashSet<int> ());
        }
        contains = this._dict[val].Count != 0;
        this._nums.Add (val);
        this._dict[val].Add (this._nums.Count - 1);
        return !contains;
    }

    /** Removes a value from the collection. Returns true if the collection contained the specified element. */
    public bool Remove (int val) {
        if (!this._dict.ContainsKey (val)) {
            return false;
        }
        if (this._dict[val].Count == 0) {
            return false;
        }
        var len = this._nums.Count;
        var last = this._nums[len - 1];
        var pos = this._dict[val].Last ();
        if (last != val) {
            this._nums[pos] = last;
            this._dict[last].Remove (len - 1);
            this._dict[last].Add (pos);
        }
        this._nums.RemoveAt (len - 1);
        this._dict[val].Remove (pos);
        return true;
    }

    /** Get a random element from the collection. */
    public int GetRandom () {
        var count = this._nums.Count;
        var next = this._random.Next (count);
        return this._nums[next];
    }
}

/**
 * Your RandomizedCollection object will be instantiated and called as such:
 * RandomizedCollection obj = new RandomizedCollection();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */