public class Solution {
    public bool CanConstruct (string ransomNote, string magazine) {
        var store = new int[26];
        for (int i = 0; i < magazine.Length; i++) {
            var pos = magazine[i] - 'a';
            store[pos]++;
        }
        for (int i = 0; i < ransomNote.Length; i++) {
            var pos = ransomNote[i] - 'a';
            if (store[pos] == 0) {
                return false;
            }
            store[pos]--;
        }
        return true;
    }
}