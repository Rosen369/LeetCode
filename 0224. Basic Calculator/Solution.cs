public class Solution {
    public int Calculate (string s) {
        if (string.IsNullOrEmpty (s)) {
            return 0;
        }
        var stack = new Stack<char> ();
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == ' ') {
                continue;
            }
            if (s[i] == ')') {
                var cList = new List<char> ();
                while (stack.Peek () != '(') {
                    cList.Add (stack.Pop ());
                }
                stack.Pop ();
                var numStr = CalcList (cList).ToString ();
                for (int j = 0; j < numStr.Length; j++) {
                    stack.Push (numStr[j]);
                }
            } else {
                stack.Push (s[i]);
            }
        }
        var sList = stack.ToList ();
        return CalcList (sList);
    }

    public int CalcList (IList<char> list) {
        var res = 0;
        if (list.Count () == 0) {
            return res;
        }
        list = list.Reverse ().ToList ();
        list.Add ('+');
        var numStr = string.Empty;
        var opt = '+';
        for (int i = 0; i < list.Count (); i++) {
            if (list[i] == '-' || list[i] == '+') {
                if (string.IsNullOrEmpty (numStr)) {
                    numStr += list[i];
                    continue;
                }
                if (opt == '-') {
                    res -= Convert.ToInt32 (numStr);
                } else {
                    res += Convert.ToInt32 (numStr);
                }
                opt = list[i];
                numStr = string.Empty;
            } else {
                numStr += list[i];
            }
        }
        return res;
    }
}