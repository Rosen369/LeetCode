public class Solution {
    public IList<IList<string>> GroupAnagrams (string[] strs) {
        var res = new Dictionary<string, IList<string>> ();
        for (int i = 0; i < strs.Length; i++) {
            var arr = strs[i].ToCharArray ();
            Array.Sort (arr);
            var key = new string (arr);
            if (!res.ContainsKey (key)) {
                res.Add (key, new List<string> ());
            }
            res[key].Add (strs[i]);
        }
        return res.Values.ToList ();
    }
}