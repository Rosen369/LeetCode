public class Solution {
    public string RemoveKdigits (string num, int k) {
        if (k >= num.Length) {
            return "0";
        }
        var index = 0;
        var stack = new Stack<char> ();
        while (index < num.Length) {
            while (stack.Count != 0 && k > 0 && stack.Peek () > num[index]) {
                stack.Pop ();
                k--;
            }
            stack.Push (num[index]);
            index++;
        }
        while (k > 0) {
            stack.Pop ();
            k--;
        }
        var sb = new StringBuilder ();
        while (stack.Count != 0) {
            sb.Insert (0, stack.Pop ());
        }
        var res = sb.ToString ().TrimStart ('0');
        res = string.IsNullOrEmpty (res) ? "0" : res;
        return res;
    }
}