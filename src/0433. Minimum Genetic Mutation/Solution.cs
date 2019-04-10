public class Solution {
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