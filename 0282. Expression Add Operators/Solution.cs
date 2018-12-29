public class Solution {
    public IList<string> AddOperators (string num, int target) {
        var res = new List<string> ();
        if (string.IsNullOrEmpty (num)) {
            return res;
        }
        this.DFS (res, num, target, string.Empty, 0, 0);
        return res;
    }

    private void DFS (List<string> res, string num, int target, string curr, long value, long multed) {
        if (string.IsNullOrEmpty (num)) {
            if (value == target) {
                res.Add (curr);
            }
            return;
        }
        for (int i = 1; i <= num.Length; i++) {
            var left = num.Substring (0, i);
            if (left[0] == '0' && left.Length > 1) {
                break;
            }
            var right = num.Substring (i);
            var subVal = Convert.ToInt64 (left);
            if (string.IsNullOrEmpty (curr)) {
                this.DFS (res, right, target, left, subVal, subVal);
            } else {
                this.DFS (res, right, target, curr + "+" + left, value + subVal, subVal);
                this.DFS (res, right, target, curr + "-" + left, value - subVal, -subVal);
                this.DFS (res, right, target, curr + "*" + left, value - multed + multed * subVal, multed * subVal);
            }
        }
    }
}