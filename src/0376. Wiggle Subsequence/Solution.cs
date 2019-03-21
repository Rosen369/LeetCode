public class Solution {
    public int WiggleMaxLength (int[] nums) {
        var len = nums.Length;
        if (len == 0) {
            return 0;
        }
        var up = new int[len];
        var down = new int[len];
        up[0] = 1;
        down[0] = 1;
        for (int i = 1; i < len; i++) {
            if (nums[i] > nums[i - 1]) {
                up[i] = down[i - 1] + 1;
                down[i] = down[i - 1];
            } else if (nums[i] < nums[i - 1]) {
                down[i] = up[i - 1] + 1;
                up[i] = up[i - 1];
            } else {
                down[i] = down[i - 1];
                up[i] = up[i - 1];
            }
        }
        return Math.Max (up[len - 1], down[len - 1]);
    }
}