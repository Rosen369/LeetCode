public class Solution {
    public IList<int> GetRow (int rowIndex) {
        if (rowIndex == 0) {
            return new List<int> { 1 };
        }
        var res = new List<int> ();
        res.Add (1);
        for (int i = 2; i <= rowIndex + 1; i++) {
            var row = new List<int> ();
            row.Add (1);
            for (int j = 1; j < i - 1; j++) {
                var num = res[j - 1] + res[j];
                row.Add (num);
            }
            row.Add (1);
            res = row;
        }
        return res;
    }
}