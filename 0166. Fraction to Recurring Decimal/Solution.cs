public class Solution {
    public string FractionToDecimal (int numerator, int denominator) {
        if (numerator == 0) {
            return "0";
        }
        var sb = new StringBuilder ();
        if ((numerator > 0) ^ (denominator > 0)) {
            sb.Append ("-");
        }
        var num = Math.Abs ((long) numerator);
        var den = Math.Abs ((long) denominator);

        sb.Append (num / den);
        num %= den;
        if (num == 0) {
            return sb.ToString ();
        }

        sb.Append (".");
        var dict = new Dictionary<long, int> ();
        dict.Add (num, sb.Length);
        while (num != 0) {
            num *= 10;
            sb.Append (num / den);
            num %= den;
            if (dict.ContainsKey (num)) {
                var index = dict[num];
                sb.Insert (index, "(");
                sb.Append (")");
                break;
            } else {
                dict.Add (num, sb.Length);
            }
        }
        return sb.ToString ();
    }
}