public class Solution {
    public IList<int> LargestDivisibleSubset (int[] nums) {
        var res = new List<int> ();
        if (nums.Length == 0) {
            return res;
        }
        var count = new int[nums.Length];
        var pre = new int[nums.Length];
        Array.Sort (nums);
        for (int i = 0; i < nums.Length; i++) {
            count[i] = 1;
            pre[i] = -1;
            for (int j = i - 1; j >= 0; j--) {
                if (nums[i] % nums[j] == 0) {
                    if (count[j] + 1 > count[i]) {
                        count[i] = count[j] + 1;
                        pre[i] = j;
                    }
                }
            }
        }
        var largest = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (count[i] > count[largest]) {
                largest = i;
            }
        }
        while (largest >= 0) {
            res.Add (nums[largest]);
            largest = pre[largest];
        }
        return res;
    }
}