public class Solution {
    public int Reverse (int x) {
        var result = 0;
        var list = x.ToString ().ToList ();
        list.Reverse ();
        if (list.Last () == '-') {
            list.RemoveAt (list.Count () - 1);
            list.Insert (0, '-');
        }
        var reversedStr = new string (list.ToArray ());
        Int32.TryParse (reversedStr, out result);
        return result;
    }
}