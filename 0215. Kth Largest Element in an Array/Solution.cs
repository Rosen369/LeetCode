public class Solution {
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