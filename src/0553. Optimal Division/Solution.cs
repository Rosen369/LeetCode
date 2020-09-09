public class Solution {
    public string OptimalDivision (int[] nums) {
        if (nums.Length == 1) {
            return nums[0] + "";
        }
        if (nums.Length == 2) {
            return nums[0] + "/" + nums[1];
        }
        var sb = new StringBuilder ();
        sb.Append (nums[0]).Append ("/").Append ("(");
        for (int i = 1; i < nums.Length; i++) {
            sb.Append (nums[i]).Append ("/");
        }
        var res = sb.ToString ().TrimEnd ('/') + ")";
        return res;
    }
}