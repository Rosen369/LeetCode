public class Solution {
    public int MagicalString (int n) {
        var nums = new List<int> ();
        nums.Add (1);
        nums.Add (2);
        nums.Add (2);
        var repIndex = 2;
        var i = 3;
        var num = 1;
        var res = 0;
        while (i < n) {
            var repeat = nums[repIndex];
            repIndex++;
            if (repeat == 1) {
                nums.Add (num);
                i++;
            } else {
                nums.Add (num);
                nums.Add (num);
                i += 2;
            }
            num ^= 3;
        }

        for (i = 0; i < n; i++) {
            if (nums[i] == 1) res++;
        }
        return res;
    }
}