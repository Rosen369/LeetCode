public class Solution {
    public string ComplexNumberMultiply (string a, string b) {
        var a1 = Convert.ToInt32 (a.Split ('+') [0]);
        var a2 = Convert.ToInt32 (a.Split ('+') [1].Split ('i') [0]);
        var b1 = Convert.ToInt32 (b.Split ('+') [0]);
        var b2 = Convert.ToInt32 (b.Split ('+') [1].Split ('i') [0]);

        var c1 = a1 * b1 - a2 * b2;
        var c2 = a1 * b2 + a2 * b1;

        var res = c1 + "+" + c2 + "i";
        return res;
    }
}