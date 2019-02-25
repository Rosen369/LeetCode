public class Solution {
    public IList<int> TopKFrequent (int[] nums, int k) {
        var buckets = new IList<int>[nums.Length + 1];
        var dict = new Dictionary<int, int> ();
        for (int i = 0; i < nums.Length; i++) {
            var num = nums[i];
            if (!dict.ContainsKey (num)) {
                dict.Add (num, 0);
            }
            dict[num]++;
        }
        var keys = dict.Keys.ToList ();
        for (int i = 0; i < keys.Count; i++) {
            var key = keys[i];
            var frequency = dict[key];
            if (buckets[frequency] == null) {
                buckets[frequency] = new List<int> ();
            }
            buckets[frequency].Add (key);
        }
        var res = new List<int> ();
        for (int i = buckets.Length - 1; i >= 0 && k > 0; i--) {
            if (buckets[i] != null) {
                res.AddRange (buckets[i]);
                k -= buckets[i].Count;
            }
        }
        return res;
    }
}