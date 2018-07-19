public class Solution {
    public string Multiply (string num1, string num2) {
        if (num1 == "0" || num2 == "0") {
            return "0";
        }
        var sum = new List<char> ();
        for (int i = num2.Length - 1; i >= 0; i--) {
            var multiply = MultiplyBit (num1, ToInt (num2[i]), num2.Length - 1 - i);
            AddMultiplied (sum, multiply);
        }
        sum.Reverse ();
        return new String (sum.ToArray ());
    }

    public void AddMultiplied (List<char> sum, List<char> add) {
        var sumLength = sum.Count;
        var addLength = add.Count;
        if (sumLength < addLength) {
            for (int i = 0; i < addLength - sumLength; i++) {
                sum.Add ('0');
            }
        }
        if (addLength < sumLength) {
            for (int i = 0; i < sumLength - addLength; i++) {
                add.Add ('0');
            }
        }
        var flow = 0;
        for (int i = 0; i < sum.Count; i++) {
            var total = ToInt (sum[i]) + ToInt (add[i]) + flow;
            var strTotal = total.ToString ();
            if (total >= 10) {
                flow = 1;
                sum[i] = strTotal[1];
            } else {
                flow = 0;
                sum[i] = strTotal[0];
            }
        }
        if (flow == 1) {
            sum.Add ('1');
        }
    }

    public List<char> MultiplyBit (string num, int bit, int digit) {
        var res = new List<char> ();
        for (int i = 0; i < digit; i++) {
            res.Add ('0');
        }
        var flow = 0;
        for (int i = num.Length - 1; i >= 0; i--) {
            var multiply = ToInt (num[i]) * bit + flow;
            var strMultiply = multiply.ToString ();
            if (multiply >= 10) {
                flow = ToInt (strMultiply[0]);
                res.Add (strMultiply[1]);
            } else {
                flow = 0;
                res.Add (strMultiply[0]);
            }
        }
        if (flow != 0) {
            res.Add (flow.ToString () [0]);
        }
        return res;
    }

    public int ToInt (char c) {
        return (int) (c - '0');
    }
}