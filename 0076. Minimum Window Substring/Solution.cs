public class Solution {
    public string MinWindow (string s, string t) {
        var dic = new Dictionary<char, int> ();
        for (int i = 0; i < t.Length; i++) {
            if (dic.ContainsKey (t[i])) {
                dic[t[i]] = dic[t[i]] + 1;
            } else {
                dic.Add (t[i], 1);
            }
        }
        var left = 0;
        var start = 0;
        var length = s.Length + 1;
        var count = 0;
        for (int right = 0; right < s.Length; right++) {
            if (dic.ContainsKey (s[right])) {
                dic[s[right]] = dic[s[right]] - 1;
                if (dic[s[right]] >= 0) {
                    count++;
                }
                while (count == t.Length) {
                    if (right - left + 1 < length) {
                        start = left;
                        length = right - left + 1;
                    }
                    if (dic.ContainsKey (s[left])) {
                        dic[s[left]] = dic[s[left]] + 1;
                        if (dic[s[left]] > 0) {
                            count--;
                        }
                    }
                    left++;
                }
            }
        }
        if (length > s.Length) {
            return string.Empty;
        }
        return s.Substring (start, length);
    }
}