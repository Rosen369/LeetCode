public class Solution {
    public string[] FindRelativeRanks (int[] nums) {
        var ranks = new int[nums.Length];
        nums.CopyTo (ranks, 0);
        Array.Sort (ranks);
        Array.Reverse (ranks);
        var dict = new Dictionary<int, string> ();
        for (int i = 0; i < ranks.Length; i++) {
            var rank = "" + (i + 1);
            if (rank == "1") rank = "Gold Medal";
            if (rank == "2") rank = "Silver Medal";
            if (rank == "3") rank = "Bronze Medal";
            dict.Add (ranks[i], rank);
        }
        var res = new string[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            res[i] = dict[nums[i]];
        }
        return res;
    }
}