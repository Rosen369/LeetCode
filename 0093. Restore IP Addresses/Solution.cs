public class Solution {
    public IList<string> RestoreIpAddresses (string s) {
        var res = new List<string> ();
        SplitNext (s, new List<string> (), res);
        return res;
    }

    public void SplitNext (string s, IList<string> curr, IList<string> res) {
        if (curr.Count () == 4 && string.IsNullOrEmpty (s)) {
            var ip = string.Join (".", curr.ToArray ());
            if (!res.Contains (ip)) {
                res.Add (ip);
            }
        }
        if (curr.Count () == 4 || string.IsNullOrEmpty (s)) {
            return;
        }
        for (int i = 1; i <= 3 && i <= s.Length; i++) {
            var part = s.Substring (0, i);
            if (CheckNumValid (part)) {
                curr.Add (part);
                SplitNext (s.Substring (i), curr, res);
                curr.RemoveAt (curr.Count () - 1);
            }
        }
    }

    public bool CheckNumValid (string strNum) {
        if (strNum.Length > 3) {
            return false;
        }
        var num = Convert.ToInt32 (strNum);
        if (num > 255) {
            return false;
        }
        if (num == 0 && strNum.Length > 1) {
            return false;
        }
        if (num != 0 && strNum[0] == '0') {
            return false;
        }
        return true;
    }
}