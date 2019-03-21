public class Solution {
    public int[] SingleNumber (int[] nums) {
        var res = new int[2];
        var xor = 0;
        for (int i = 0; i < nums.Length; i++) {
            xor ^= nums[i];
        }
        var pos = xor & -xor;
        for (int i = 0; i < nums.Length; i++) {
            if ((nums[i] & pos) == 0) {
                res[0] ^= nums[i];
            } else {
                res[1] ^= nums[i];
            }
        }
        return res;
    }
}