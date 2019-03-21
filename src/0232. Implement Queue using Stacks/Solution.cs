public class MyQueue {

    /** Initialize your data structure here. */
    public MyQueue () {
        _inStack = new Stack<int> ();
        _outStack = new Stack<int> ();
    }

    private Stack<int> _inStack;
    private Stack<int> _outStack;

    /** Push element x to the back of queue. */
    public void Push (int x) {
        _inStack.Push (x);
    }

    /** Removes the element from in front of queue and returns that element. */
    public int Pop () {
        this.Peek ();
        return _outStack.Pop ();
    }

    /** Get the front element. */
    public int Peek () {
        if (_outStack.Count == 0) {
            while (_inStack.Count != 0) {
                _outStack.Push (_inStack.Pop ());
            }
        }
        return _outStack.Peek ();
    }

    /** Returns whether the queue is empty. */
    public bool Empty () {
        return _inStack.Count + _outStack.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */