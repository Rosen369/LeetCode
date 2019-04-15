public class Solution {
    public IList<int> FindAnagrams (string s, string p) {
        var res = new List<int> ();
        if (s.Length < p.Length) {
            return res;
        }
        var dict = new int[26];
        for (int i = 0; i < p.Length; i++) {
            dict[p[i] - 'a']++;
        }
        var left = 0;
        var right = 0;
        var count = p.Length;
        while (right < s.Length) {
            if (dict[s[right] - 'a'] >= 1) {
                count--;
            }
            dict[s[right] - 'a']--;
            right++;
            if (count == 0) {
                res.Add (left);
            }
            if (right - left != p.Length) {
                continue;
            }
            if (dict[s[left] - 'a'] >= 0) {
                count++;
            }
            dict[s[left] - 'a']++;
            left++;
        }
        return res;
    }
}