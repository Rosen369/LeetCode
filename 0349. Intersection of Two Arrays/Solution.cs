public class Solution {
    public int[] Intersection (int[] nums1, int[] nums2) {
        var set = new HashSet<int> (nums1);
        var intersect = new HashSet<int> ();
        for (int i = 0; i < nums2.Length; i++) {
            if (set.Contains (nums2[i])) {
                intersect.Add (nums2[i]);
            }
        }
        return intersect.ToArray ();
    }
}