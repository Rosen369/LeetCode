public class MinStack {

    /** initialize your data structure here. */
    public MinStack () {
        _stack = new List<int> ();
        _min = new List<int> ();
    }

    private IList<int> _stack;

    private IList<int> _min;

    public void Push (int x) {
        _stack.Add (x);
        if (_min.Count () == 0) {
            _min.Add (x);
        } else {
            _min.Add (Math.Min (_min[_min.Count () - 1], x));
        }

    }

    public void Pop () {
        _stack.RemoveAt (_stack.Count () - 1);
        _min.RemoveAt (_min.Count () - 1);
    }

    public int Top () {
        return _stack[_stack.Count () - 1];
    }

    public int GetMin () {
        return _min[_min.Count () - 1];
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */