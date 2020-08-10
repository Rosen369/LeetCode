public class Solution {
    public int FindCircleNum (int[][] M) {
        var visited = new HashSet<int> ();
        var res = 0;
        for (int i = 0; i < M.Length; i++) {
            if (visited.Contains (i)) {
                continue;
            }
            res++;
            this.DFS (M, visited, i);
        }
        return res;
    }

    private void DFS (int[][] M, HashSet<int> visited, int n) {
        if (visited.Contains (n)) {
            return;
        }
        visited.Add (n);
        for (int i = 0; i < M.Length; i++) {
            if (M[n][i] == 1) {
                this.DFS (M, visited, i);
            }
        }
    }
}