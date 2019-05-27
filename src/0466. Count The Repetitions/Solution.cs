public class Solution {
    public int GetMaxRepetitions (string s1, int n1, string s2, int n2) {
        var s1N = 0;
        var s2N = 0;
        var s1Index = 0;
        var s2Index = 0;
        var count = 0;
        while (s1N < n1) {
            if (s1[s1Index] == s2[s2Index]) {
                s2Index++;
                if (s2Index == s2.Length) {
                    s2N++;
                    s2Index = 0;
                    if (s2N == n2) {
                        count++;
                        s2N = 0;
                    }
                }
            }
            s1Index++;
            if (s1Index == s1.Length) {
                s1N++;
                s1Index = 0;
            }
        }
        return count;
    }
}