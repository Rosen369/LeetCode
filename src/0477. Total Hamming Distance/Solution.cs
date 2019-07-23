public class Solution {
    public int TotalHammingDistance (int[] nums) {
        var res = 0;
        var max = 0;
        for (int i = 0; i < 32; i++) {
            var ones = 0;
            var zeros = 0;
            for (int j = 0; j < nums.Length; j++) {
                if ((nums[j] & 1) == 1) {
                    ones++;
                } else {
                    zeros++;
                }
                nums[j] = nums[j] >> 1;
            }
            res += ones * zeros;
        }
        return res;
    }
}