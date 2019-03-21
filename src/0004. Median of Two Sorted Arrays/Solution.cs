public class Solution {
    public double FindMedianSortedArrays (int[] nums1, int[] nums2) {
        var list = new List<int> ();
        var middle = 0.0;
        var index1 = 0;
        var index2 = 0;
        while (true) {
            if (nums1.Length == index1 && nums2.Length == index2) {
                break;
            }
            if (nums1.Length == index1) {
                list.Add (nums2[index2]);
                index2++;
                continue;
            }
            if (nums2.Length == index2) {
                list.Add (nums1[index1]);
                index1++;
                continue;
            }
            if (nums1[index1] <= nums2[index2]) {
                list.Add (nums1[index1]);
                index1++;
            } else {
                list.Add (nums2[index2]);
                index2++;
            }
        }
        var count = list.Count ();
        if (count % 2 == 0) {
            middle = (float) (list[count / 2] + list[count / 2 - 1]) / 2;
        } else {
            middle = list[(count - 1) / 2];
        }
        return middle;
    }
}