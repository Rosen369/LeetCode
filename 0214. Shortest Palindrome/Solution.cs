public class Solution {
    public string ShortestPalindrome (string s) {
        if (string.IsNullOrEmpty (s)) {
            return s;
        }
        var revArr = s.ToCharArray ();
        Array.Reverse (revArr);
        var rev = new string (revArr);
        for (int i = 1; i < s.Length; i++) {
            var leftSub = rev.Substring (i);
            var rightSub = s.Substring (0, s.Length - i);
            if (leftSub == rightSub) {
                return rev.Substring (0, i) + s;
            }
        }
        return string.Empty;
    }
}