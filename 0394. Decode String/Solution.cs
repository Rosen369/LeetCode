public class Solution {
    public string DecodeString (string s) {
        var sub = new Stack<string> ();
        var times = new Stack<int> ();
        sub.Push (string.Empty);
        for (int i = 0; i < s.Length; i++) {
            if (char.IsDigit (s[i])) {
                var count = 0;
                while (char.IsDigit (s[i])) {
                    count = count * 10 + s[i] - '0';
                    i++;
                }
                times.Push (count);
                i--;
            } else if (s[i] == '[') {
                sub.Push (string.Empty);
            } else if (s[i] == ']') {
                var top = sub.Pop ();
                var time = times.Pop ();
                var sb = new StringBuilder ();
                for (int j = 0; j < time; j++) {
                    sb.Append (top);
                }
                sub.Push (sub.Pop () + sb.ToString ());
            } else {
                sub.Push (sub.Pop () + s[i]);
            }
        }
        return sub.Pop ();
    }
}