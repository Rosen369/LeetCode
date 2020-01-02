public class Solution {
    public string ConvertToBase7 (int num) {
        if (num == 0) {
            return "0";
        }
        var symbol = num < 0;
        var stack = new Stack<int> ();
        while (num != 0) {
            if (symbol) {
                stack.Push (-num % 7);
            } else {
                stack.Push (num % 7);
            }
            num = num / 7;
        }
        var sb = new StringBuilder ();
        if (symbol) {
            sb.Append ("-");
        }
        while (stack.Count > 0) {
            sb.Append (stack.Pop ());
        }
        return sb.ToString ();
    }
}