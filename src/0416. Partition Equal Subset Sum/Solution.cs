public class Solution1 {
    //dp solution
    //Runtime: 124 ms
    //Memory Usage: 22.4 MB
    public bool CanPartition (int[] nums) {
        var sum = 0;
        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i];
        }
        if (sum % 2 == 1) {
            return false;
        }
        var target = sum / 2;
        var dp = new bool[target + 1];
        dp[0] = true;
        for (int i = 0; i < nums.Length; i++) {
            var n = nums[i];
            for (int j = target; j >= n; j--) {
                dp[j] = dp[j] || dp[j - n];
            }
        }
        return dp[target];
    }
}

public class Solution2 {
    //hashset solution
    //Runtime: 156 ms
    //Memory Usage: 32.9 MB
    public bool CanPartition (int[] nums) {
        var sum = 0;
        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i];
        }
        if (sum % 2 == 1) {
            return false;
        }
        var target = sum / 2;
        var set = new HashSet<int> ();
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == target) {
                return true;
            }
            var pre = set.ToList ();
            for (int j = 0; j < pre.Count; j++) {
                if (nums[i] + pre[j] == target) {
                    return true;
                }
                set.Add (nums[i] + pre[j]);
            }
            set.Add (nums[i]);
        }
        return false;
    }
}