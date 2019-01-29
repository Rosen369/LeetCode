public class Solution {
    public string RemoveDuplicateLetters (string s) {
        if (s == null || s.Length <= 1) return s;

        var lastPosMap = new Dictionary<char, int> ();
        for (int i = 0; i < s.Length; i++) {
            if (lastPosMap.ContainsKey (s[i])) {
                lastPosMap[s[i]] = i;
            } else {
                lastPosMap.Add (s[i], i);
            }
        }
        var result = new char[lastPosMap.Count];
        int begin = 0, end = FindMinLastPos (lastPosMap);
        for (int i = 0; i < result.Length; i++) {
            var minChar = (char) ('z' + 1);
            for (int k = begin; k <= end; k++) {
                if (lastPosMap.ContainsKey (s[k]) && s[k] < minChar) {
                    minChar = s[k];
                    begin = k + 1;
                }
            }
            result[i] = minChar;
            if (i == result.Length - 1) break;
            lastPosMap.Remove (minChar);
            if (s[end] == minChar) end = FindMinLastPos (lastPosMap);
        }
        return new string (result);
    }

    private int FindMinLastPos (IDictionary<char, int> dict) {
        if (dict == null || dict.Count == 0) return -1;
        int minLastPos = int.MaxValue;
        foreach (var value in dict.Values) {
            minLastPos = Math.Min (minLastPos, value);
        }
        return minLastPos;
    }
}