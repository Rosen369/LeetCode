public class Solution {
    public int MyAtoi (string str) {
        str = str.TrimStart (' ');
        if (string.IsNullOrEmpty (str)) {
            return 0;
        }
        var digits = new List<char> () { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        var negative = false;
        var charList = new List<char> () { '0' };
        if (str[0] == '-' || str[0] == '+') {
            negative = str[0] == '-' ? !negative : negative;
            str = str.Substring (1);
        }
        for (var i = 0; i < str.Length; i++) {
            if (!digits.Contains (str[i])) {
                break;
            }
            charList.Add (str[i]);
        }
        str = new string (charList.ToArray ());
        str = negative ? "-" + str : str;
        var success = Int32.TryParse (str, out var number);
        if (!success && negative) {
            return int.MinValue;
        } else if (!success && !negative) {
            return int.MaxValue;
        }
        return number;
    }
}