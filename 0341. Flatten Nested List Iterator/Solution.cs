/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class NestedIterator {

    public NestedIterator (IList<NestedInteger> nestedList) {
        this._stack = new Stack<NestedInteger> ();
        for (int i = nestedList.Count - 1; i >= 0; i--) {
            var nested = nestedList[i];
            this._stack.Push (nested);
        }
    }

    private Stack<NestedInteger> _stack;

    public bool HasNext () {
        while (this._stack.Count != 0) {
            var peek = this._stack.Peek ();
            if (peek.IsInteger ()) {
                return true;
            }
            var top = this._stack.Pop ();
            var topList = top.GetList ();
            for (int i = topList.Count - 1; i >= 0; i--) {
                var nested = topList[i];
                this._stack.Push (nested);
            }
        }
        return false;
    }

    public int Next () {
        return this._stack.Pop ().GetInteger ();
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */