public class Solution {
    public IList<IList<int>> Combine (int n, int k) {
        var res = new List<IList<int>> ();
        AddNext (n, k, res, new List<int> ());
        return res;
    }

    public void AddNext (int n, int k, IList<IList<int>> res, IList<int> curr) {
        if (curr.Count () == k) {
            res.Add (curr);
            return;
        }
        var nextNum = 1;
        if (curr.Count != 0) {
            nextNum = curr[curr.Count () - 1] + 1;
        }
        for (int i = nextNum; i <= n; i++) {
            var next = new List<int> (curr);
            next.Add (i);
            AddNext (n, k, res, next);
        }
    }
}