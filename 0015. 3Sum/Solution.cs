public class Solution {
    public IList<IList<int>> ThreeSum (int[] nums) {
        var result = new List<IList<int>> ();
        Array.Sort (nums);
        for (int i = 0; i < nums.Length; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }
            var left = i + 1;
            var right = nums.Length - 1;
            while (left < right) {
                if (nums[i] + nums[left] + nums[right] == 0) {
                    result.Add (new List<int> { nums[i], nums[left], nums[right] });
                    while (left < right && nums[left] == nums[left + 1]) {
                        left++;
                    }
                    while (left < right && nums[right - 1] == nums[right]) {
                        right--;
                    }
                    left++;
                    right--;
                } else if (nums[i] + nums[left] + nums[right] < 0) {
                    left++;
                } else if (nums[i] + nums[left] + nums[right] > 0) {
                    right--;
                }
            }
        }
        return result;
    }
}