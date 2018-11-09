public class Solution {
    public bool CanFinish (int numCourses, int[, ] prerequisites) {
        var preLength = prerequisites.GetLength (0);
        var dict = new Dictionary<int, IList<int>> ();
        for (int i = 0; i < preLength; i++) {
            if (!dict.ContainsKey (prerequisites[i, 0])) {
                dict[prerequisites[i, 0]] = new List<int> ();
            }
            dict[prerequisites[i, 0]].Add (prerequisites[i, 1]);
        }
        var visited = new HashSet<int> ();
        for (int i = 0; i < numCourses; i++) {
            if (!DFS (dict, visited, new HashSet<int> (), i)) {
                return false;
            }
        }
        return true;
    }

    public bool DFS (IDictionary<int, IList<int>> dict, HashSet<int> visited, HashSet<int> pre, int curr) {
        if (visited.Contains (curr)) {
            return true;
        }
        if (pre.Contains (curr)) {
            return false;
        }
        if (dict.ContainsKey (curr)) {
            var req = dict[curr];
            for (int i = 0; i < req.Count (); i++) {
                pre.Add (curr);
                if (!DFS (dict, visited, pre, req[i])) {
                    return false;
                }
                pre.Remove (curr);
            }
        }
        visited.Add (curr);
        return true;
    }
}