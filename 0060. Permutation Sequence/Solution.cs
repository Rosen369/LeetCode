public class Solution {
    public string GetPermutation (int n, int k) {
        var res = new List<string> ();
        CombineNext (n, new List<char> (), res);
        return res[k - 1];
    }

    public void CombineNext (int n, IList<char> curr, IList<string> list) {
        if (curr.Count () == n) {
            var str = new string (curr.ToArray ());
            if (!list.Contains (str)) {
                list.Add (str);
            }
            return;
        }
        for (char i = '1'; i <= n.ToString () [0]; i++) {
            if (!curr.Contains (i)) {
                curr.Add (i);
                CombineNext (n, curr, list);
                curr.Remove (i);
            }
        }
    }
}