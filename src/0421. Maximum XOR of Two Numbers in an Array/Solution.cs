public class Solution {
    public int FindMaximumXOR (int[] nums) {
        var max = 0;
        var mask = 0;
        for (int i = 31; i >= 0; i--) {
            mask = mask | (1 << i);
            var set = new HashSet<int> ();
            foreach (var num in nums) {
                set.Add (num & mask);
            }
            var tmp = max | (1 << i);
            foreach (var prefix in set) {
                if (set.Contains (tmp ^ prefix)) {
                    max = tmp;
                    break;
                }
            }
        }
        return max;
    }
}