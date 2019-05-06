public class Solution {
    //hash set solution
    //Runtime: 92 ms
    //Memory Usage: 21.9 MB
    public bool CircularArrayLoop (int[] nums) {
        var bad = new HashSet<int> ();
        for (int i = 0; i < nums.Length; i++) {
            if (bad.Contains (i)) {
                continue;
            }
            var next = i;
            var direction = nums[i] > 0;
            var visited = new HashSet<int> () { i };
            while (true) {
                var pre = next;
                next = (pre + nums[pre]) % nums.Length;
                next = next < 0 ? nums.Length + next : next;
                if (next == pre) {
                    bad.Add (pre);
                    break;
                }
                if (nums[next] > 0 != direction || bad.Contains (next)) {
                    bad.UnionWith (visited);
                    break;
                }
                if (visited.Contains (next)) {
                    return true;
                }
                visited.Add (next);
            }
        }
        return false;
    }
}