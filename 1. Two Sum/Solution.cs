public class Solution {
    public int[] TwoSum (int[] nums, int target) {
        var dic = new Dictionary<int, int> ();
        for (int i = 0; i < nums.Length; i++) {
            var completion = target - nums[i];
            if (dic.ContainsKey (completion)) {
                return new int[] { dic[completion], i };
            }
            if (!dic.ContainsKey (nums[i])) {
                dic.Add (nums[i], i);
            }
        }
        throw new ArgumentException ("no match solution in nums");
    }
}