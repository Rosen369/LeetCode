public class Solution {
    public bool IsIsomorphic (string s, string t) {
        var weightS = Weight (s);
        var weightT = Weight (t);
        for (int i = 0; i < s.Length; i++) {
            if (weightS[i] != weightT[i]) {
                return false;
            }
        }
        return true;
    }

    public int[] Weight (string s) {
        var res = new int[s.Length];
        var dict = new Dictionary<char, int> ();
        var weight = 0;
        for (int i = 0; i < s.Length; i++) {
            if (!dict.ContainsKey (s[i])) {
                dict.Add (s[i], weight++);
            }
            res[i] = dict[s[i]];
        }
        return res;
    }
}