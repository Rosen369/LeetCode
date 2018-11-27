public class MyStack {

    /** Initialize your data structure here. */
    public MyStack () {
        _queue = new Queue<int> ();
    }

    private Queue<int> _queue;

    /** Push element x onto stack. */
    public void Push (int x) {
        _queue.Enqueue (x);
        for (int i = 0; i < _queue.Count - 1; i++) {
            var n = _queue.Dequeue ();
            _queue.Enqueue (n);
        }
    }

    /** Removes the element on top of the stack and returns that element. */
    public int Pop () {
        return _queue.Dequeue ();
    }

    /** Get the top element. */
    public int Top () {
        return _queue.Peek ();
    }

    /** Returns whether the stack is empty. */
    public bool Empty () {
        return _queue.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */