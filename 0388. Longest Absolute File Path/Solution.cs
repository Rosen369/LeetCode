public class Solution {
    public int LengthLongestPath (string input) {
        var stack = new Stack<int> ();
        stack.Push (0);
        var sArray = input.Split ('\n');
        var max = 0;
        for (int i = 0; i < sArray.Length; i++) {
            var s = sArray[i];
            var level = s.LastIndexOf ('\t') + 1;
            while (level + 1 < stack.Count) {
                stack.Pop ();
            }
            var len = stack.Peek () + s.Length - level + 1;
            stack.Push (len);
            if (s.Contains (".")) {
                max = Math.Max (max, len - 1);
            }
        }
        return max;
    }
}