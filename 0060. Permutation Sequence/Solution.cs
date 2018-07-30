public class Solution {
    public string GetPermutation (int n, int k) {
        var res = string.Empty;
        var factorial = 1;
        var charList = new List<char> ();
        // for (char i = n.ToString () [0]; i >= '1'; i--) {
        for (char i = '1'; i <= n.ToString () [0]; i++) {
            charList.Add (i);
        }
        for (int i = 1; i <= n; i++) {
            factorial = factorial * i;
        }
        k--;
        while (n > 0) {
            var pos = k / (factorial / n);
            factorial = factorial / n;
            k = k - factorial * pos;
            n = n - 1;
            res += charList[pos];
            charList.Remove (charList[pos]);
        }
        return res;
    }
}