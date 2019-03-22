public class Solution {
    public string ToHex (int num) {
        var map = "0123456789abcdef";
        if (num == 0) return "0";
        var n = num & 0xffffffff;
        var result = string.Empty;
        while (n != 0) {
            result = map[(int) (n % 16)] + result;
            n /= 16;
        }
        return result;
    }
}