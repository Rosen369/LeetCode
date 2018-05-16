public class Solution {
    public string Convert (string s, int numRows) {
        if (numRows == 1) {
            return s;
        }
        var result = new List<char> ();
        var rows = new Dictionary<int, List<char>> ();
        var rowIndex = 0;
        var directionDown = true;
        for (var i = 0; i < numRows; i++) {
            rows.Add (i, new List<char> ());
        }
        for (var i = 0; i < s.Length; i++) {
            rows[rowIndex].Add (s[i]);
            if (rowIndex == 0) {
                directionDown = true;
            } else if (rowIndex == numRows - 1) {
                directionDown = false;
            }
            if (directionDown) {
                rowIndex++;
            } else {
                rowIndex--;
            }
        }
        for (var i = 0; i < numRows; i++) {
            result.AddRange (rows[i]);
        }
        return new string (result.ToArray ());
    }
}