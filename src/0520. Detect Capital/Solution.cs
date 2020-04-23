public class Solution {
    public bool DetectCapitalUse (string word) {
        if (word.Length == 1) {
            return true;
        }
        var head = word[0] <= 'Z';
        var flag = word[1] <= 'Z';
        if (head == false && flag == true) {
            return false;
        }
        for (int i = 2; i < word.Length; i++) {
            var cap = word[i] <= 'Z';
            if (cap != flag) {
                return false;
            }
        }
        return true;
    }
}