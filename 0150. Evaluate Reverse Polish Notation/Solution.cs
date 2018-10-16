public class Solution {
    public int EvalRPN (string[] tokens) {
        var ops = new List<string> () { "+", "-", "*", "/" };
        var stack = new Stack<int> ();
        for (int i = 0; i < tokens.Length; i++) {
            if (!ops.Contains (tokens[i])) {
                stack.Push (Convert.ToInt32 (tokens[i]));
            } else {
                var value = 0;
                var op2 = stack.Pop ();
                var op1 = stack.Pop ();
                if (tokens[i] == "+") {
                    value = op1 + op2;
                } else if (tokens[i] == "-") {
                    value = op1 - op2;
                } else if (tokens[i] == "*") {
                    value = op1 * op2;
                } else if (tokens[i] == "/") {
                    value = op1 / op2;
                }
                stack.Push (value);
            }
        }
        return stack.Pop ();
    }
}