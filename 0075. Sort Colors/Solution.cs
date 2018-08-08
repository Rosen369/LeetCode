public class Solution {
    public void SortColors (int[] nums) {
        var n0 = -1;
        var n1 = -1;
        var n2 = -1;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) {
                nums[++n2] = 2;
                nums[++n1] = 1;
                nums[++n0] = 0;
            } else if (nums[i] == 1) {
                nums[++n2] = 2;
                nums[++n1] = 1;
            } else if (nums[i] == 2) {
                nums[++n2] = 2;
            }
        }
    }
}