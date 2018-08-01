public class Solution {
    public string AddBinary (string a, string b) {
        if (string.IsNullOrEmpty (a)) {
            return b;
        }
        if (string.IsNullOrEmpty (b)) {
            return a;
        }
        var sb = new StringBuilder ();
        var carry = 0;
        var i = a.Length - 1;
        var j = b.Length - 1;
        while (i >= 0 || j >= 0 || carry > 0) {
            var a1 = i >= 0 ? a[i] - '0' : 0;
            var b1 = j >= 0 ? b[j] - '0' : 0;
            var num = a1 + b1 + carry;
            sb.Insert (0, num % 2);
            if (num > 1) {
                carry = 1;
            } else {
                carry = 0;
            }
            i--;
            j--;
        }
        return sb.ToString ();
    }
}