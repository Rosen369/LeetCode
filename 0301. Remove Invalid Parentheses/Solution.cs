public class Solution {
    public IList<string> RemoveInvalidParentheses (string s) {
        var res = new List<string> ();
        if (string.IsNullOrEmpty (s)) {
            res.Add (string.Empty);
            return res;
        }
        var visited = new HashSet<string> ();
        var queue = new Queue<string> ();
        var found = false;
        queue.Enqueue (s);
        while (queue.Count () != 0) {
            var curr = queue.Dequeue ();
            if (visited.Contains (curr)) {
                continue;
            } else {
                visited.Add (curr);
            }
            if (IsValid (curr)) {
                res.Add (curr);
                found = true;
            }
            if (found) {
                continue;
            }
            for (int i = 0; i < curr.Length; i++) {
                if (curr[i] == '(' || curr[i] == ')') {
                    var left = curr.Substring (0, i);
                    var right = curr.Substring (i + 1);
                    queue.Enqueue (left + right);
                }
            }
        }
        return res;
    }

    public bool IsValid (string s) {
        var count = 0;
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(') {
                count++;
            }
            if (s[i] == ')') {
                count--;
            }
            if (count < 0) {
                return false;
            }
        }
        return count == 0;
    }
}