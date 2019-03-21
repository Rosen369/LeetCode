public class Solution {
    public string CountAndSay (int n) {
        var res = "1";
        if (n == 1) {
            return res;
        }
        for (int i = 0; i < n - 1; i++) {
            res = CountNext (res);
        }
        return res;
    }

    public string CountNext (string current) {
        var sb = new StringBuilder ();
        var count = 1;
        var say = current[0];
        for (int i = 1; i < current.Length; i++) {
            if (current[i] == say) {
                count++;
            } else {
                sb.Append (count.ToString ()).Append (say);
                say = current[i];
                count = 1;
            }
        }
        sb.Append (count.ToString ()).Append (say);
        return sb.ToString ();
    }
}