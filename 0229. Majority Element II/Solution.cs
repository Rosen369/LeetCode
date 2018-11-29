public class Solution {
    public IList<int> MajorityElement (int[] nums) {
        var res = new List<int> ();
        if (nums.Length == 0) {
            return res;
        }
        var major = nums.Length / 3;
        var counter1 = 0;
        var counter2 = 0;
        var candidate1 = 0;
        var candidate2 = 1;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == nums[candidate1]) {
                counter1++;
            } else if (nums[i] == nums[candidate2]) {
                counter2++;
            } else if (counter1 == 0) {
                counter1 = 1;
                candidate1 = i;
            } else if (counter2 == 0) {
                counter2 = 1;
                candidate2 = i;
            } else {
                counter1--;
                counter2--;
            }
        }
        counter1 = 0;
        counter2 = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == nums[candidate1]) {
                counter1++;
            } else if (nums[i] == nums[candidate2]) {
                counter2++;
            }
        }
        if (counter1 > major) {
            res.Add (nums[candidate1]);
        }
        if (counter2 > major) {
            res.Add (nums[candidate2]);
        }
        return res;
    }
}