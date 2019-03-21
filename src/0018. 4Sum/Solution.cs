public class Solution {
    public IList<IList<int>> FourSum (int[] nums, int target) {
        Array.Sort (nums);
        var map = new Dictionary<string, IList<int>> ();
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                var left = j + 1;
                var right = nums.Length - 1;
                while (left < right) {
                    var sum = nums[i] + nums[j] + nums[left] + nums[right];
                    if (sum == target) {
                        var key = string.Empty + nums[i] + nums[j] + nums[left] + nums[right];
                        if (!map.ContainsKey (key)) {
                            map.Add (key, new List<int> { nums[i], nums[j], nums[left], nums[right] });
                        }
                        left++;
                        right--;
                    } else if (sum < target) {
                        left++;
                    } else {
                        right--;
                    }
                }
            }
        }
        return map.Values.ToList ();
    }
}