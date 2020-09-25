public class Solution {
    public string ReverseWords (string s) {
        var words = s.Split (' ');
        for (int i = 0; i < words.Length; i++) {
            words[i] = new string (words[i].ToCharArray ().Reverse ().ToArray ());
        }
        var res = string.Join (" ", words);
        return res;
    }
}