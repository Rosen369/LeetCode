public class Solution {
    public void WiggleSort (int[] nums) {
        var n = nums.Length;
        var median = FindKthLargest (nums, (n + 1) / 2);
        var left = new List<int> ();
        var right = new List<int> ();
        for (int i = 0; i < n; i++) {
            if (nums[i] < median) {
                left.Add (nums[i]);
            } else if (nums[i] > median) {
                right.Add (nums[i]);
            }
        }
        Array.Fill (nums, median);
        for (int i = n - 1; i >= 0; i--) {
            if (left.Count == 0) {
                break;
            }
            if (i % 2 == 1) {
                continue;
            }
            nums[i] = left[0];
            left.RemoveAt (0);
        }
        for (int i = 0; i < n; i++) {
            if (right.Count == 0) {
                break;
            }
            if (i % 2 == 0) {
                continue;
            }
            nums[i] = right[0];
            right.RemoveAt (0);
        }
    }

    public int FindKthLargest (int[] nums, int k) {
        k = nums.Length - k;
        Shuffle (nums);
        return Partition (nums, 0, nums.Length - 1, k);
    }

    private int Partition (int[] nums, int left, int right, int k) {
        if (left == right) {
            return nums[left];
        }
        var basement = nums[left];
        var i = left;
        var j = right;
        while (i < j) {
            while (nums[j] >= basement && i < j) {
                j--;
            }
            nums[i] = nums[j];
            while (nums[i] < basement && i < j) {
                i++;
            }
            nums[j] = nums[i];
        }
        nums[i] = basement;
        if (k == i) {
            return nums[i];
        }
        if (k < i) {
            return Partition (nums, left, i - 1, k);
        } else {
            return Partition (nums, i + 1, right, k);
        }
    }

    private void Exchange (int[] nums, int i, int j) {
        var tmp = nums[i];
        nums[i] = nums[j];
        nums[j] = tmp;
    }

    private void Shuffle (int[] nums) {
        var random = new Random ();
        for (int index = 1; index < nums.Length; index++) {
            int r = random.Next (index + 1);
            Exchange (nums, index, r);
        }
    }
}