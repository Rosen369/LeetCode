public class Solution {
    public int[] MaxSlidingWindow (int[] nums, int k) {
        if (nums.Length == 0 || k == 0) {
            return new int[0];
        }
        var mq = new MaxQueue ();
        var res = new int[nums.Length - k + 1];
        for (int i = 0; i < nums.Length; i++) {
            mq.Push (nums[i]);
            if (i < k - 1) {
                continue;
            }
            res[i - k + 1] = mq.Max ();
            mq.Pop ();
        }
        return res;
    }
}

public class MaxQueue {
    public MaxQueue () {
        this._maxs = new LinkedList<int> ();
        this._nums = new Queue<int> ();
    }
    private Queue<int> _nums;
    private LinkedList<int> _maxs;

    public void Push (int x) {
        _nums.Enqueue (x);
        while (_maxs.Count != 0 && _maxs.Last.Value < x) {
            _maxs.RemoveLast ();
        }
        _maxs.AddLast (x);
    }

    public void Pop () {
        if (_nums.Peek () == _maxs.First.Value) {
            _maxs.RemoveFirst ();
        }
        _nums.Dequeue ();
    }

    public int Max () {
        return _maxs.First.Value;
    }
}