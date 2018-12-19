public class Solution {
    public IList<int> DiffWaysToCompute (string input) {
        var res = new List<int> ();
        if (string.IsNullOrEmpty (input)) {
            return res;
        }
        for (int i = 0; i < input.Length; i++) {
            if (input[i] == '+' || input[i] == '-' || input[i] == '*') {
                var leftStr = input.Substring (0, i);
                var rightStr = input.Substring (i + 1);
                var leftRes = DiffWaysToCompute (leftStr);
                var rightRes = DiffWaysToCompute (rightStr);
                foreach (var left in leftRes) {
                    foreach (var right in rightRes) {
                        if (input[i] == '+') {
                            res.Add (left + right);
                        } else if (input[i] == '-') {
                            res.Add (left - right);
                        } else if (input[i] == '*') {
                            res.Add (left * right);
                        }
                    }
                }
            }
        }
        if (res.Count == 0) {
            res.Add (Convert.ToInt32 (input));
        }
        return res;
    }
}