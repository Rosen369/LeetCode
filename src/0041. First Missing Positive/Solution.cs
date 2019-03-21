public class Solution {
    public int FirstMissingPositive (int[] nums) {
        var dic = new Dictionary<int, bool> ();
        for (int i = 0; i < nums.Length; i++) {
            dic.Add (i + 1, false);
        }
        for (int i = 0; i < nums.Length; i++) {
            if (dic.ContainsKey (nums[i])) {
                dic[nums[i]] = true;
            }
        }
        for (int i = 0; i < nums.Length; i++) {
            if (dic[i + 1] == false) {
                return i + 1;
            }
        }
        return nums.Length + 1;
    }
}