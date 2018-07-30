public class Solution {
    public string GetPermutation (int n, int k) {
        var res = new StringBuilder ();
        var factorial = 1;
        var list = new List<int> ();
        for (int i = 1; i <= n; i++) {
            factorial = factorial * i;
            list.Add (i);
        }
        k--;
        for (; n > 0; n--) {
            var pos = k / (factorial / n);
            factorial = factorial / n;
            k = k - factorial * pos;
            res.Append (list[pos]);
            list.Remove (list[pos]);
        }
        return res.ToString ();
    }
}