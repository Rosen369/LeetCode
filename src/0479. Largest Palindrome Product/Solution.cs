public class Solution {
    public int LargestPalindrome (int n) {
        var max = (long) Math.Pow (10, n) - 1;
        var min = max / 10;
        for (var h = max; h > min; h--) {
            var left = h;
            var right = 0L;
            for (var i = h; i != 0;) {
                right = right * 10 + i % 10;
                i /= 10;
                left *= 10;
            }
            var palindrome = left + right;
            for (var i = max; i > min; i--) {
                var j = palindrome / i;
                if (j > i) {
                    break;
                }
                if (palindrome % i == 0) {
                    return (int) (palindrome % 1337);
                }
            }
        }
        return 9;
    }
}