public class Solution {
    public bool IsValid (string s) {
        var stack = new Stack<char> ();
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{') {
                stack.Push (s[i]);
            } else {
                if (stack.Count == 0) {
                    return false;
                }
                if (s[i] == ')' && stack.Pop () != '(') {
                    return false;
                }
                if (s[i] == ']' && stack.Pop () != '[') {
                    return false;
                }
                if (s[i] == '}' && stack.Pop () != '{') {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}