public class Solution {
    public int FindMaxLength (int[] nums) {
        var max = 0;
        var dict = new Dictionary<int, int> ();
        dict.Add (0, -1);
        var count = 0;
        for (int i = 0; i < nums.Length; i++) {
            count += nums[i] == 0 ? -1 : 1;
            if (dict.ContainsKey (count)) {
                max = Math.Max (max, i - dict[count]);
            } else {
                dict.Add (count, i);
            }
        }
        return max;
    }
}