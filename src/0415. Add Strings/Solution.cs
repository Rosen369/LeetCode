public class Solution {
    public string AddStrings (string num1, string num2) {
        var num1Arr = num1.ToCharArray ();
        var num2Arr = num2.ToCharArray ();
        Array.Reverse (num1Arr);
        Array.Reverse (num2Arr);
        var list = new List<char> ();
        var carry = 0;
        var index = 0;
        while (index < num1Arr.Length || index < num2Arr.Length) {
            var add = 0;
            if (index >= num1Arr.Length) {
                add = num2Arr[index] - '0' + carry;
            } else if (index >= num2Arr.Length) {
                add = num1Arr[index] - '0' + carry;
            } else {
                add = num1Arr[index] - '0' + num2Arr[index] - '0' + carry;
            }
            carry = add / 10;
            var c = (char) (add % 10 + '0');
            list.Add (c);
            index++;
        }
        if (carry != 0) {
            list.Add ((char) (carry + '0'));
        }
        var arr = list.ToArray ();
        Array.Reverse (arr);
        var res = new string (arr);
        res.TrimStart ('0');
        return res;
    }
}