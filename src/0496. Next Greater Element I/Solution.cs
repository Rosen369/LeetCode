public class Solution {
    public int[] NextGreaterElement (int[] nums1, int[] nums2) {
        var res = new int[nums1.Length];
        var dict = new Dictionary<int, int> ();
        var stack = new Stack<int> ();
        for (int i = 0; i < nums2.Length; i++) {
            var n = nums2[i];
            while (stack.Count > 0 && stack.Peek () < n) {
                dict.Add (stack.Pop (), n);
            }
            stack.Push (n);
        }
        for (int i = 0; i < nums1.Length; i++) {
            var n = nums1[i];
            if (dict.ContainsKey (n)) {
                res[i] = dict[n];
            } else {
                res[i] = -1;
            }
        }
        return res;
    }
}