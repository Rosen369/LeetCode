public class Solution {
    public int SingleNumber (int[] nums) {
        var set = new HashSet<int> ();
        for (int i = 0; i < nums.Length; i++) {
            if (set.Contains (nums[i])) {
                set.Remove (nums[i]);
            } else {
                set.Add (nums[i]);
            }
        }
        return set.First ();
    }
}