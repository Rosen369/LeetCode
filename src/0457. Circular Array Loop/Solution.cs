public class Solution1 {
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

public class Solution2 {
    //fast slow pointer solution
    //Runtime: 116 ms
    //Memory Usage: 21.7 MB
    public bool CircularArrayLoop (int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) {
                continue;
            }
            var m = i;
            var n = Next (i, nums);
            while (nums[n] * nums[i] > 0 && nums[Next (n, nums)] * nums[i] > 0) {
                if (m == n) {
                    if (m == Next (m, nums)) {
                        break;
                    }
                    return true;
                }
                m = Next (m, nums);
                n = Next (Next (n, nums), nums);
            }
            var j = i;
            while (nums[j] * nums[i] > 0) {
                nums[j] = 0;
                j = Next (j, nums);
            }
        }
        return false;
    }

    private int Next (int i, int[] nums) {
        var n = (i + nums[i]) % nums.Length;
        n = n < 0 ? nums.Length + n : n;
        return n;
    }
}