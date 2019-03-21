public class Solution {
    public string LongestCommonPrefix (string[] strs) {
        var result = string.Empty;
        if (strs.Length == 0) {
            return result;
        }
        for (int i = 0; i < strs[0].Length; i++) {
            for (int j = 0; j < strs.Length; j++) {
                if (strs[j].Length <= i) {
                    return result;
                }
                if (strs[j][i] != strs[0][i]) {
                    return result;
                }
            }
            result += strs[0][i];
        }
        return result;
    }
}