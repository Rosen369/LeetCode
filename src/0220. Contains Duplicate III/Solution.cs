public class Solution {
    public bool ContainsNearbyAlmostDuplicate (int[] nums, int k, int t) {
        if (k < 1 || t < 0) return false;
        var dict = new Dictionary<long, long> ();
        for (int i = 0; i < nums.Length; i++) {
            long remappedNum = (long) nums[i] - int.MinValue;
            long bucket = remappedNum / ((long) t + 1);
            if (dict.ContainsKey (bucket)) {
                return true;
            }
            if (dict.ContainsKey (bucket - 1) && remappedNum - dict[bucket - 1] <= t) {
                return true;
            }
            if (dict.ContainsKey (bucket + 1) && dict[bucket + 1] - remappedNum <= t) {
                return true;
            }
            if (dict.Keys.Count () >= k) {
                long lastBucket = ((long) nums[i - k] - int.MinValue) / ((long) t + 1);
                dict.Remove (lastBucket);
            }
            dict.Add (bucket, remappedNum);
        }
        return false;
    }
}