public class Solution1 {
    //BFS solution
    //Runtime: 108 ms
    //Memory Usage: 21.8 MB
    public int MinMutation (string start, string end, string[] bank) {
        var set = new HashSet<string> (bank);
        if (!set.Contains (end)) {
            return -1;
        }
        var visited = new HashSet<string> ();
        var mutations = 0;
        var current = new List<string> ();
        current.Add (start);
        var replace = new char[] { 'A', 'C', 'G', 'T' };
        while (current.Count != 0) {
            var next = new List<string> ();
            mutations++;
            foreach (var dna in current) {
                if (visited.Contains (dna)) {
                    continue;
                }
                for (int i = 0; i < dna.Length; i++) {
                    for (int j = 0; j < replace.Length; j++) {
                        var arr = dna.ToCharArray ();
                        arr[i] = replace[j];
                        var mutate = new string (arr);
                        if (mutate == end) {
                            return mutations;
                        }
                        if (set.Contains (mutate)) {
                            next.Add (mutate);
                        }
                    }
                }
                visited.Add (dna);
            }
            current = next;
        }
        return -1;
    }
}

public class Solution2 {
    //DFS solution
    //Runtime: 92 ms
    //Memory Usage: 21.9 MB
    public int MinMutation (string start, string end, string[] bank) {
        var set = new HashSet<string> (bank);
        if (!set.Contains (end)) {
            return -1;
        }
        return DFS (set, start, end);
    }

    private int DFS (HashSet<string> set, string start, string end) {
        if (start == end) {
            return 0;
        }
        var res = int.MaxValue;
        var replace = new char[] { 'A', 'C', 'G', 'T' };
        set.Remove (start);
        for (int i = 0; i < start.Length; i++) {
            for (int j = 0; j < replace.Length; j++) {
                var arr = start.ToCharArray ();
                arr[i] = replace[j];
                var next = new string (arr);
                if (!set.Contains (next)) {
                    continue;
                }
                var dfsRes = DFS (set, next, end);
                if (dfsRes != -1) {
                    res = Math.Min (res, 1 + dfsRes);
                }
            }
        }
        set.Add (start);
        if (res == int.MaxValue) {
            return -1;
        }
        return res;
    }
}