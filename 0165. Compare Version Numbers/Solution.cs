public class Solution {
    public int CompareVersion (string version1, string version2) {
        var ver1 = version1.Split ('.').Select (e => Convert.ToInt32 (e)).ToList ();
        var ver2 = version2.Split ('.').Select (e => Convert.ToInt32 (e)).ToList ();
        var max = Math.Max (ver1.Count (), ver2.Count ());
        while (ver1.Count () < max) {
            ver1.Add (0);
        }
        while (ver2.Count () < max) {
            ver2.Add (0);
        }
        for (int i = 0; i < max; i++) {
            if (ver1[i] == ver2[i]) {
                continue;
            }
            if (ver1[i] < ver2[i]) {
                return -1;
            } else {
                return 1;
            }
        }
        return 0;
    }
}