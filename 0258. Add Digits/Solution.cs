public class Solution {
    public int AddDigits (int num) {
        if (num < 10) {
            return num;
        }
        var str = num.ToString ();
        var res = 0;
        for (int i = 0; i < str.Length; i++) {
            res += str[i] - '0';
        }
        return AddDigits (res);
    }
}