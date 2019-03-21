public class Solution {
    public IList<IList<int>> Generate (int numRows) {
        var res = new List<IList<int>> ();
        if (numRows == 0) {
            return res;
        }
        res.Add (new List<int> { 1 });
        if (numRows == 1) {
            return res;
        }
        for (int i = 2; i <= numRows; i++) {
            var row = new List<int> ();
            row.Add (1);
            for (int j = 1; j < i - 1; j++) {
                var num = res[i - 2][j - 1] + res[i - 2][j];
                row.Add (num);
            }
            row.Add (1);
            res.Add (row);
        }
        return res;
    }
}