public class Solution {
    public IList<string> GenerateParenthesis (int n) {
        var res = new List<string> ();
        BackTrack (res, string.Empty, 0, 0, n);
        return res;
    }

    public void BackTrack (IList<string> list, string subStr, int open, int close, int n) {
        if (subStr.Length == n * 2) {
            list.Add (subStr);
            return;
        }
        if (open < n) {
            BackTrack (list, subStr + '(', open + 1, close, n);
        }
        if (close < open) {
            BackTrack (list, subStr + ')', open, close + 1, n);
        }
    }
}