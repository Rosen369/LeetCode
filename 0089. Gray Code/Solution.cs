public class Solution {
    public IList<int> GrayCode (int n) {
        var res = new List<int> ();
        if (n == 0) {
            res.Add (0);
            return res;
        }
        res.Add (0);
        res.Add (1);
        int val = 2;
        for (int i = 1; i < n; i++) {
            int length = res.Count;
            for (int j = length - 1; j >= 0; j--) {
                res.Add (val + res[j]);
            }
            val *= 2;
        }
        return res;
    }
}