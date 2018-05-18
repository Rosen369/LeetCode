public class Solution {
    public IList<string> LetterCombinations (string digits) {
        var result = new List<string> ();
        if (string.IsNullOrEmpty (digits)) {
            return result;
        }
        var digitMap = new Dictionary<int, IList<char>> ();
        digitMap.Add ('2', new List<char> { 'a', 'b', 'c' });
        digitMap.Add ('3', new List<char> { 'd', 'e', 'f' });
        digitMap.Add ('4', new List<char> { 'g', 'h', 'i' });
        digitMap.Add ('5', new List<char> { 'j', 'k', 'l' });
        digitMap.Add ('6', new List<char> { 'm', 'n', 'o' });
        digitMap.Add ('7', new List<char> { 'p', 'q', 'r', 's' });
        digitMap.Add ('8', new List<char> { 't', 'u', 'v' });
        digitMap.Add ('9', new List<char> { 'w', 'x', 'y', 'z' });
        var height = 1;
        var index = new List<int> ();
        for (int i = 0; i < digits.Length; i++) {
            height = height * digitMap[digits[i]].Count ();
            index.Add (0);
        }
        for (int i = 0; i < height; i++) {
            var line = new List<char> ();
            for (int j = 0; j < digits.Length; j++) {
                line.Add (digitMap[digits[j]][index[j]]);
            }
            index[digits.Length - 1] = index[digits.Length - 1] + 1;
            for (int j = index.Count () - 1; j >= 0; j--) {
                if (index[j] >= digitMap[digits[j]].Count ()) {
                    index[j] = 0;
                    if (j - 1 >= 0) {
                        index[j - 1] = index[j - 1] + 1;
                    }
                }
            }
            result.Add (new string (line.ToArray ()));
        }
        return result;
    }
}