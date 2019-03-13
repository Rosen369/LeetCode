/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // Constructor initializes an empty nested list.
 *     public NestedInteger();
 *
 *     // Constructor initializes a single integer.
 *     public NestedInteger(int value);
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // Set this NestedInteger to hold a single integer.
 *     public void SetInteger(int value);
 *
 *     // Set this NestedInteger to hold a nested list and adds a nested integer to it.
 *     public void Add(NestedInteger ni);
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class Solution {
    public NestedInteger Deserialize (string s) {
        if (string.IsNullOrEmpty (s)) {
            return null;
        }
        if (s[0] != '[') {
            return new NestedInteger (Convert.ToInt32 (s));
        }
        var stack = new Stack<NestedInteger> ();
        NestedInteger curr = null;
        var left = 0;
        for (var right = 0; right < s.Length; right++) {
            if (s[right] == '[') {
                if (curr != null) {
                    stack.Push (curr);
                }
                curr = new NestedInteger ();
                left = right + 1;
            } else if (s[right] == ']') {
                var num = s.Substring (left, right - left);
                if (!string.IsNullOrEmpty (num))
                    curr.Add (new NestedInteger (Convert.ToInt32 (num)));
                if (stack.Count != 0) {
                    NestedInteger pop = stack.Pop ();
                    pop.Add (curr);
                    curr = pop;
                }
                left = right + 1;
            } else if (s[right] == ',') {
                if (s[right - 1] != ']') {
                    var num = s.Substring (left, right - left);
                    curr.Add (new NestedInteger (Convert.ToInt32 (num)));
                }
                left = right + 1;
            }
        }
        return curr;
    }
}