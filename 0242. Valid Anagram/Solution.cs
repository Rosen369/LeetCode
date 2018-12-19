public class Solution {
    public bool IsAnagram (string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        var store = new int[26];
        for (int i = 0; i < s.Length; i++) {
            store[s[i] - 'a']++;
            store[t[i] - 'a']--;
        }
        for (int i = 0; i < 26; i++) {
            if (store[i] != 0) {
                return false;
            }
        }
        return true;
    }
}