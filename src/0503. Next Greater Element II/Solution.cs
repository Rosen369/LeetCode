public class Solution {
    public int[] NextGreaterElements (int[] nums) {
        var res = new int[nums.Length];
        var stack = new Stack<int> ();
        for (int c = 0; c < 2; c++) {
            for (int i = nums.Length - 1; i >= 0; i--) {
                while (stack.Count > 0 && nums[stack.Peek ()] <= nums[i]) {
                    stack.Pop ();
                }
                if (stack.Count > 0) {
                    res[i] = nums[stack.Peek ()];
                } else {
                    res[i] = -1;
                }
                stack.Push (i);
            }
        }
        return res;
    }
}