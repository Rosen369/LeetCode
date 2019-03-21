public class Solution {
    public int LongestValidParentheses (string s) {
        var res = 0;
        var stack = new Stack<int> ();
        stack.Push (-1);
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(') {
                stack.Push (i);
            } else {
                if (stack.Count == 0) {
                    break;
                } else {
                    stack.Pop ();
                    if (stack.Count == 0) {
                        stack.Push (i);
                    } else {
                        res = Math.Max (res, i - stack.Peek ());
                    }
                }
            }
        }
        return res;
    }
}