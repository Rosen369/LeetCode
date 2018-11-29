public class Solution {
    public int Calculate (string s) {
        if (string.IsNullOrEmpty (s)) return 0;
        s += "+";
        var stack = new Stack<int> ();
        var sign = '+';
        var num = 0;
        var res = 0;
        foreach (var c in s) {
            if (c == ' ') continue;
            if (char.IsDigit (c)) {
                num = num * 10 + (c - '0');
            } else {
                if (sign == '+') {
                    stack.Push (num);
                } else if (sign == '-') {
                    stack.Push (-num);
                } else if (sign == '*') {
                    stack.Push (stack.Pop () * num);
                } else if (sign == '/') {
                    stack.Push (stack.Pop () / num);
                }
                num = 0;
                sign = c;
            }
        }
        foreach (var n in stack) {
            res += n;
        }
        return res;
    }
}