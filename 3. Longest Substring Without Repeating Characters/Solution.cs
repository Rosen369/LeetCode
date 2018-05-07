public class Solution {
    public int LengthOfLongestSubstring (string s) {
        var max = 0;
        var exist = new List<char> ();
        for (var i = 0; i < s.Length; i++) {
            while (exist.Contains (s[i])) {
                exist.RemoveAt (0);
            }
            exist.Add (s[i]);
            if (max < exist.Count) {
                max = exist.Count;
            }
        }
        return max;
    }
}