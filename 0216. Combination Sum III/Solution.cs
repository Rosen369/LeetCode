public class Solution {
    public IList<IList<int>> CombinationSum3 (int k, int n) {
        var res = new List<IList<int>> ();
        BackTracking (res, new List<int> (), 1, k, n, 0);
        return res;
    }

    public void BackTracking (IList<IList<int>> res, IList<int> current, int num, int k, int n, int sum) {
        if (current.Count () > k) {
            return;
        }
        if (sum == n && current.Count () == k) {
            res.Add (new List<int> (current));
            return;
        }
        for (int i = num; i <= 9; i++) {
            current.Add (i);
            BackTracking (res, current, i + 1, k, n, sum + i);
            current.RemoveAt (current.Count () - 1);
        }
    }
}