public class Solution1 {
    //better brute force
    //Runtime: 1444 ms
    //Memory Usage: 27.2 MB
    public bool Find132pattern (int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            var pre = int.MinValue;
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[j] <= nums[i]) {
                    continue;
                }
                if (nums[j] < pre) {
                    return true;
                }
                pre = nums[j];
            }
        }
        return false;
    }
}

public class Solution2 {
    //stack solution
    //Runtime: 108 ms
    //Memory Usage: 27.8 MB
    public bool Find132pattern (int[] nums) {
        if (nums.Length < 3) {
            return false;
        }
        var stack = new Stack<int> ();
        var min = new int[nums.Length];
        min[0] = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            min[i] = Math.Min (min[i - 1], nums[i]);
        }
        for (int i = nums.Length - 1; i >= 0; i--) {
            while (stack.Count > 0 && stack.Peek () <= min[i]) {
                stack.Pop ();
            }
            if (stack.Count > 0 && stack.Peek () < nums[i]) {
                return true;
            }
            stack.Push (nums[i]);
        }
        return false;
    }
}