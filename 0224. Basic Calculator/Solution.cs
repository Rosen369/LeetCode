public class Solution {
    public int Calculate (string s) {
        var stack = new Stack<int> ();
        var result = 0;
        var number = 0;
        var sign = 1;
        for (int i = 0; i < s.Length; i++) {
            var c = s[i];
            if (char.IsDigit (c)) {
                number = 10 * number + (int) (c - '0');
            } else if (c == '+') {
                result += sign * number;
                number = 0;
                sign = 1;
            } else if (c == '-') {
                result += sign * number;
                number = 0;
                sign = -1;
            } else if (c == '(') {
                stack.Push (result);
                stack.Push (sign);
                sign = 1;
                result = 0;
            } else if (c == ')') {
                result += sign * number;
                number = 0;
                result *= stack.Pop ();
                result += stack.Pop ();
            }
        }
        result += sign * number;
        return result;
    }
}