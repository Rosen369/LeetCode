public class Solution {
    public int RomanToInt (string s) {
        var result = 0;
        var roman = new Dictionary<string, int> ();
        roman.Add ("MMM", 3000);
        roman.Add ("MM", 2000);
        roman.Add ("M", 1000);
        roman.Add ("CM", 900);
        roman.Add ("DCCC", 800);
        roman.Add ("DCC", 700);
        roman.Add ("DC", 600);
        roman.Add ("D", 500);
        roman.Add ("CD", 400);
        roman.Add ("CCC", 300);
        roman.Add ("CC", 200);
        roman.Add ("C", 100);
        roman.Add ("XC", 90);
        roman.Add ("LXXX", 80);
        roman.Add ("LXX", 70);
        roman.Add ("LX", 60);
        roman.Add ("L", 50);
        roman.Add ("XL", 40);
        roman.Add ("XXX", 30);
        roman.Add ("XX", 20);
        roman.Add ("X", 10);
        roman.Add ("IX", 9);
        roman.Add ("VIII", 8);
        roman.Add ("VII", 7);
        roman.Add ("VI", 6);
        roman.Add ("V", 5);
        roman.Add ("IV", 4);
        roman.Add ("III", 3);
        roman.Add ("II", 2);
        roman.Add ("I", 1);
        foreach (var pair in roman) {
            if (s.StartsWith (pair.Key)) {
                result += pair.Value;
                s = s.Substring (pair.Key.Length);
            }
        }
        return result;
    }
}