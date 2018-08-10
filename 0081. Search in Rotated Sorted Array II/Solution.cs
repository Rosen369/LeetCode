public class Solution {
    public int Search (int[] nums, int target) {
        var compress = new List<int> ();
        for (int i = 0; i < nums.Length; i++) {
            if (!compress.Contains (nums[i])) {
                compress.Add (nums[i]);
            }
        }
        var low = 0;
        var high = compress.Count ();
        while (low < high) {
            var mid = (low + high) / 2;
            var num = compress[mid];
            if (compress[mid] < compress[0] != target < compress[0]) {
                if (target < compress[0]) {
                    num = int.MinValue;
                } else {
                    num = int.MaxValue;
                }
            }
            if (num < target) {
                low = mid + 1;
            } else if (num > target) {
                high = mid;
            } else {
                return true;
            }
        }
        return false;
    }
}