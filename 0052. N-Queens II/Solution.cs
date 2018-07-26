public class Solution {
    public int TotalNQueens (int n) {
        var count = 0;
        var colsSet = new HashSet<int> ();
        var slashSet = new HashSet<int> ();
        var backslashSet = new HashSet<int> ();
        Backtracking (n, 0, ref count, colsSet, slashSet, backslashSet);
        return count;
    }

    public void Backtracking (int n, int row, ref int count, HashSet<int> colsSet, HashSet<int> slashSet, HashSet<int> backslashSet) {
        if (row == n) count++;
        for (var col = 0; col < n; col++) {
            var slash = col - row + n;
            var backslash = col + row;
            if (colsSet.Contains (col) || slashSet.Contains (slash) || backslashSet.Contains (backslash)) {
                continue;
            }
            colsSet.Add (col);
            slashSet.Add (slash);
            backslashSet.Add (backslash);
            Backtracking (n, row + 1, ref count, colsSet, slashSet, backslashSet);
            colsSet.Remove (col);
            slashSet.Remove (slash);
            backslashSet.Remove (backslash);
        }
    }
}