public class Solution {
    public bool IsPalindrome (int x) {
        if (x < 0) {
            return false;
        }
        var left = x;
        var reverse = 0;
        while (left > 0) {
            var digit = left % 10;
            left = left / 10;
            reverse = reverse * 10 + digit;
        }
        return reverse == x;
    }
}