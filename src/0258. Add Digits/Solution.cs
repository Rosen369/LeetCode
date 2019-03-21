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

    public int AddDigitsMath (int num) {
        //https://en.wikipedia.org/wiki/Digital_root
        return 1 + (num - 1) % 9;
    }
}