public class Solution {
    public bool IsHappy (int n) {
        var set = new HashSet<int> ();
        while (n != 1) {
            var res = 0;
            while (n > 0) {
                var bit = n % 10;
                res += bit * bit;
                n = n / 10;
            }
            if (set.Contains (res)) {
                return false;
            }
            set.Add (res);
            n = res;
        }
        return true;
    }
}