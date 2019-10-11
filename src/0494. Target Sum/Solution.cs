public class Solution {
    ///dict solution
    ///Runtime: 156 ms
    ///Memory Usage: 32.5 MB
    public int FindTargetSumWays (int[] nums, int S) {
        var dict = new Dictionary<int, int> ();
        if (nums[0] == 0) {
            dict.Add (0, 2);
        } else {
            dict.Add (nums[0], 1);
            dict.Add (-nums[0], 1);
        }
        for (int i = 1; i < nums.Length; i++) {
            var keys = dict.Keys.ToList ();
            var nDict = new Dictionary<int, int> ();
            for (int j = 0; j < keys.Count; j++) {
                var key = keys[j];
                var count = dict[key];
                var nKey1 = key + nums[i];
                var nKey2 = key - nums[i];
                if (nDict.ContainsKey (nKey1)) {
                    nDict[nKey1] += count;
                } else {
                    nDict.Add (nKey1, count);
                }
                if (nDict.ContainsKey (nKey2)) {
                    nDict[nKey2] += count;
                } else {
                    nDict.Add (nKey2, count);
                }
            }
            dict = nDict;
        }
        if (dict.ContainsKey (S)) {
            return dict[S];
        }
        return 0;
    }
}