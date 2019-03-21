public class Solution {
    public int[] Intersect (int[] nums1, int[] nums2) {
        var set = new HashSet<int> (nums1);
        var dict1 = new Dictionary<int, int> ();
        var dict2 = new Dictionary<int, int> ();
        var intersect = new HashSet<int> ();
        for (int i = 0; i < nums1.Length; i++) {
            if (!dict1.ContainsKey (nums1[i])) {
                dict1.Add (nums1[i], 0);
            }
            dict1[nums1[i]]++;
        }
        for (int i = 0; i < nums2.Length; i++) {
            if (set.Contains (nums2[i])) {
                intersect.Add (nums2[i]);
            }
            if (!dict2.ContainsKey (nums2[i])) {
                dict2.Add (nums2[i], 0);
            }
            dict2[nums2[i]]++;
        }
        var res = new List<int> ();
        var interList = intersect.ToList ();
        for (int i = 0; i < interList.Count; i++) {
            var num = interList[i];
            var count1 = dict1[num];
            var count2 = dict2[num];
            var min = Math.Min (count1, count2);
            for (int j = 0; j < min; j++) {
                res.Add (num);
            }
        }
        return res.ToArray ();
    }
}