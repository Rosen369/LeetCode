public class Solution {
    public string ConvertToTitle (int n) {
        var list = new List<char> ();
        while (n != 0) {
            n--;
            list.Add ((char) (n % 26 + 65));
            n = n / 26;
        }
        list.Reverse ();
        return new string (list.ToArray ());
    }
}