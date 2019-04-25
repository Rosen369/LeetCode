public class Solution {
    public IList<int> FindDisappearedNumbers (int[] nums) {
        var res = new List<int> ();
        for (int i = 0; i < nums.Length; i++) {
            var index = Math.Abs (nums[i]) - 1;
            if (nums[index] > 0) {
                nums[index] = -nums[index];
            }
        }
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > 0) {
                res.Add (i + 1);
            }
        }
        return res;
    }
}