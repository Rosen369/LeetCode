public class Solution {
    public int MinPatches (int[] nums, int n) {
        var pathches = 0;
        long reaches = 1;
        var index = 0;
        while (reaches <= n) {
            if (index < nums.Length && reaches >= nums[index]) {
                reaches += nums[index];
                index++;
            } else {
                reaches += reaches;
                pathches++;
            }
        }
        return pathches;
    }
}