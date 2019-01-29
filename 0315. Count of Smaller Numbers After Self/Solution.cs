public class Solution {

    public IList<int> CountSmaller (int[] nums) {
        var len = nums.Length;
        var pairs = new List<Pair> ();
        for (int i = 0; i < len; i++) {
            pairs.Add (new Pair (i, nums[i]));
        }
        MergeSort (pairs);
        var count = pairs.OrderBy (e => e.Index).Select (e => e.Count).ToList ();
        return count;
    }

    public void MergeSort (IList<Pair> pairs) {
        if (pairs.Count < 2) {
            return;
        }
        int mid = pairs.Count / 2;
        var left = new List<Pair> ();
        var right = new List<Pair> ();
        for (int i = 0; i < pairs.Count; i++) {
            if (i < mid) {
                left.Add (pairs[i]);
            } else {
                right.Add (pairs[i]);
            }
        }
        MergeSort (left);
        MergeSort (right);
        pairs.Clear ();
        var count = 0;
        var lIndex = 0;
        var rIndex = 0;
        while (lIndex < left.Count || rIndex < right.Count) {
            if (lIndex == left.Count) {
                pairs.Add (right[rIndex]);
                rIndex++;
            } else if (rIndex == right.Count) {
                left[lIndex].Count += count;
                pairs.Add (left[lIndex]);
                lIndex++;
            } else if (left[lIndex].Value <= right[rIndex].Value) {
                left[lIndex].Count += count;
                pairs.Add (left[lIndex]);
                lIndex++;
            } else {
                count++;
                pairs.Add (right[rIndex]);
                rIndex++;
            }
        }
    }

    public class Pair {

        public Pair (int index, int value) {
            this.Index = index;
            this.Value = value;
            this.Count = 0;
        }

        public int Index { get; set; }

        public int Value { get; set; }

        public int Count { get; set; }
    }
}