public class Solution {
    public string LicenseKeyFormatting (string S, int K) {
        S = S.ToUpper ();
        var sb = new StringBuilder ();
        var list = new List<char> ();
        for (int i = 0; i < S.Length; i++) {
            if (S[i] != '-') {
                list.Add (S[i]);
            }
        }
        var fGroup = list.Count () % K;
        if (fGroup > 0) {
            for (int i = 0; i < fGroup; i++) {
                sb.Append (list[i]);
            }
            sb.Append ('-');
        }
        var countK = 0;
        for (int i = fGroup; i < list.Count (); i++) {
            sb.Append (list[i]);
            countK++;
            if (countK == K) {
                sb.Append ('-');
                countK = 0;
            }
        }
        return sb.ToString ().TrimEnd ('-');
    }
}