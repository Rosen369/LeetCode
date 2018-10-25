public class Solution {
    public string LargestNumber (int[] nums) {
        if (nums.Length == 0) {
            return string.Empty;
        }
        var strs = new List<string> ();
        for (int i = 0; i < nums.Length; i++) {
            strs.Add (nums[i].ToString ());
        }
        var list = QuickSort (strs);
        if (list[0] == "0") {
            return "0";
        }
        var res = new StringBuilder ();
        for (int i = 0; i < list.Count (); i++) {
            res.Append (list[i]);
        }
        return res.ToString ();
    }

    public bool Compare (string a, string b) {
        var left = a + b;
        var right = b + a;
        if (left.CompareTo (right) > 0) {
            return true;
        }
        return false;
    }

    public IList<string> QuickSort (IList<string> nums) {
        if (nums.Count () < 2) {
            return nums;
        }
        var res = new List<string> ();
        var mid = nums[0];
        var left = new List<string> ();
        var right = new List<string> ();
        for (int i = 1; i < nums.Count (); i++) {
            if (Compare (nums[i], mid)) {
                left.Add (nums[i]);
            } else {
                right.Add (nums[i]);
            }
        }
        left = QuickSort (left).ToList ();
        right = QuickSort (right).ToList ();
        res.AddRange (left);
        res.Add (mid);
        res.AddRange (right);
        return res;
    }
}