public class Solution {

    private string[] _ones = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

    private string[] _tens = new string[] { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

    private string[] _ms = new string[] { "Hundred", "Thousand", "Million", "Billion", "Trillion" };

    public string NumberToWords (int num) {
        if (num == 0) {
            return "Zero";
        }
        var res = string.Empty;
        var index = 0;
        while (num > 0) {
            var hundreds = HundredsToWord (num % 1000);
            if (!string.IsNullOrEmpty (hundreds)) {
                if (index >= 1) {
                    res = hundreds + " " + _ms[index] + " " + res;
                } else {
                    res = hundreds + " " + res;
                }
            }
            num = num / 1000;
            index++;
        }
        return res.Trim ();
    }

    public string HundredsToWord (int num) {
        var res = string.Empty;
        if (num < 20) {
            return _ones[num];
        }
        if (num % 100 < 20) {
            res = _ones[num % 100];
        } else {
            if (num % 10 != 0) {
                res = _ones[num % 10];
            }
            res = _tens[num % 100 / 10] + " " + res.Trim ();
        }
        if (num >= 100) {
            res = _ones[num / 100] + " " + _ms[0] + " " + res.Trim ();
        }
        return res.Trim ();
    }
}