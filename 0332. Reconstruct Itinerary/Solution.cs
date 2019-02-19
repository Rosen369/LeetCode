public class Solution {
    public IList<string> FindItinerary (string[, ] tickets) {
        var len = tickets.GetLength (0);
        var dict = new Dictionary<string, IList<string>> ();
        for (int i = 0; i < len; i++) {
            var from = tickets[i, 0];
            var to = tickets[i, 1];
            if (!dict.ContainsKey (from)) {
                dict.Add (from, new List<string> ());
            }
            dict[from].Add (to);
        }
        var keys = dict.Keys.ToList ();
        for (int i = 0; i < keys.Count; i++) {
            var key = keys[i];
            dict[key] = dict[key].OrderByDescending (e => e).ToList ();
        }
        var res = new List<string> ();
        var departure = "JFK";
        Recursive (departure, dict, res);
        return res;
    }

    public void Recursive (string departure, IDictionary<string, IList<string>> dict, IList<string> res) {
        while (dict.ContainsKey (departure) && dict[departure].Count != 0) {
            var next = dict[departure][0];
            dict[departure].RemoveAt (0);
            Recursive (next, dict, res);
        }
        res.Insert (0, departure);
    }
}