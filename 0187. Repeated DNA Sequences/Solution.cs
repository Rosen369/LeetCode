public class Solution {
    public IList<string> FindRepeatedDnaSequences (string s) {
        var once = new HashSet<string> ();
        var twice = new HashSet<string> ();
        for (int i = 0; i < s.Length - 9; i++) {
            var sub = s.Substring (i, 10);
            if (once.Contains (sub)) {
                twice.Add (sub);
            }
            once.Add (sub);
        }
        return twice.ToList ();
    }
}