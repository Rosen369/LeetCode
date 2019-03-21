public class Solution {
    public bool IncreasingTriplet (int[] nums) {
        var first = int.MaxValue;
        var second = int.MaxValue;
        for (int i = 0; i < nums.Length; i++) {
            var third = nums[i];
            if (third <= first) {
                first = third;
            } else if (third <= second) {
                second = third;
            } else {
                return true;
            }
        }
        return false;
    }
}