public class Solution {
    public int FindNthDigit (int n) {
        //calculate how many digits the number has.
        var baseVal = 9L;
        var digits = 1;
        while (n - baseVal * digits > 0) {
            n -= (int) baseVal * digits;
            baseVal *= 10;
            digits++;
        }

        //calculate what the number is.

        var num = 1L;
        for (int i = 1; i < digits; i++) {
            num *= 10;
        }
        num += n / digits;

        var index = n % digits;
        if (index == 0) {
            index = digits;
            num--;
        }

        //find out which digit in the number is we wanted.
        for (int i = index; i < digits; i++) {
            num /= 10;
        }
        return (int) num % 10;
    }
}