public class Solution {
    public int FirstUniqChar (string s) {
        var store = new int[26];
        for (int i = 0; i < s.Length; i++) {
            store[s[i] - 'a']++;
        }
        for (int i = 0; i < s.Length; i++) {
            if (store[s[i] - 'a'] == 1) {
                return i;
            }
        }
        return -1;
    }
}