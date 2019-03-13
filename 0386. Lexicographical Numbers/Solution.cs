public class Solution {
    public IList<int> LexicalOrder (int n) {
        var res = new List<int> ();
        DFS (0, n, res);
        return res;
    }

    private void DFS (int curr, int n, IList<int> res) {
        for (int i = curr * 10; i < curr * 10 + 10; i++) {
            if (i > n) {
                return;
            }
            if (i == 0) {
                continue;
            }
            res.Add (i);
            DFS (i, n, res);
        }
    }
}