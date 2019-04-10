public class AllOne {

    /** Initialize your data structure here. */
    public AllOne () {
        this._head = new Bucket (0);
        this._tail = new Bucket (0);
        this._head.Next = this._tail;
        this._tail.Pre = this._head;
        this._countBucketDict = new Dictionary<int, Bucket> ();
        this._keyCountDict = new Dictionary<string, int> ();
    }

    private Bucket _head;

    private Bucket _tail;

    private IDictionary<int, Bucket> _countBucketDict;

    private IDictionary<string, int> _keyCountDict;

    /** Inserts a new key <Key> with value 1. Or increments an existing key by 1. */
    public void Inc (string key) {
        if (this._keyCountDict.ContainsKey (key)) {
            this.ChangeKey (key, 1);
        } else {
            this._keyCountDict.Add (key, 1);
            if (this._head.Next.Count != 1) {
                this.AddBucketAfter (this._head, new Bucket (1));
                this._countBucketDict.Add (1, this._head.Next);
            }
            this._head.Next.KeySet.Add (key);
        }
    }

    /** Decrements an existing key by 1. If Key's value is 1, remove it from the data structure. */
    public void Dec (string key) {
        if (this._keyCountDict.ContainsKey (key)) {
            var count = this._keyCountDict[key];
            if (count == 1) {
                this._keyCountDict.Remove (key);
                this.RemoveFromBucket (this._countBucketDict[count], key);
            } else {
                this.ChangeKey (key, -1);
            }
        }
    }

    /** Returns one of the keys with maximal value. */
    public string GetMaxKey () {
        if (this._tail.Pre == this._head) {
            return string.Empty;
        }
        return this._tail.Pre.KeySet.First ();
    }

    /** Returns one of the keys with Minimal value. */
    public string GetMinKey () {
        if (this._head.Next == this._tail) {
            return string.Empty;
        }
        return this._head.Next.KeySet.First ();
    }

    private void ChangeKey (string key, int inc) {
        var count = this._keyCountDict[key];
        var newCount = count + inc;
        this._keyCountDict[key] = newCount;
        var currBucket = this._countBucketDict[count];
        if (this._countBucketDict.ContainsKey (newCount)) {
            this._countBucketDict[newCount].KeySet.Add (key);
        } else {
            var newBucket = new Bucket (newCount);
            newBucket.KeySet.Add (key);
            this._countBucketDict.Add (newCount, newBucket);
            if (inc == 1) {
                this.AddBucketAfter (currBucket, newBucket);
            } else {
                this.AddBucketAfter (currBucket.Pre, newBucket);
            }
        }
        this.RemoveFromBucket (currBucket, key);
    }

    private void AddBucketAfter (Bucket preBucket, Bucket newBucket) {
        newBucket.Next = preBucket.Next;
        newBucket.Pre = preBucket;
        preBucket.Next.Pre = newBucket;
        preBucket.Next = newBucket;
    }

    private void RemoveFromBucket (Bucket bucket, string key) {
        bucket.KeySet.Remove (key);
        if (bucket.KeySet.Count == 0) {
            this._countBucketDict.Remove (bucket.Count);
            bucket.Pre.Next = bucket.Next;
            bucket.Next.Pre = bucket.Pre;
            bucket.Next = null;
            bucket.Pre = null;
        }
    }

    private class Bucket {
        public Bucket (int count) {
            this.Count = count;
            this.KeySet = new HashSet<string> ();
        }

        public int Count { get; set; }

        public HashSet<string> KeySet { get; set; }

        public Bucket Next { get; set; }

        public Bucket Pre { get; set; }
    }
}

/**
 * Your AllOne object will be instantiated and called as such:
 * AllOne obj = new AllOne();
 * obj.Inc(key);
 * obj.Dec(key);
 * string param_3 = obj.GetMaxKey();
 * string param_4 = obj.GetMinKey();
 */