public class Solution {
    public int CountArrangement (int N) {
        var nums = new int[N];
        for (int i = 0; i < nums.Length; i++) {
            nums[i] = i + 1;
        }
        return this.Permute (nums, 0);
    }

    private int Permute (int[] nums, int length) {
        var count = 0;
        if (nums.Length == length) {
            count++;
        }
        for (int i = length; i < nums.Length; i++) {
            this.Swap (nums, i, length);
            if (nums[length] % (length + 1) == 0 || (length + 1) % nums[length] == 0) {
                count += this.Permute (nums, length + 1);
            }
            this.Swap (nums, i, length);
        }
        return count;
    }

    private void Swap (int[] nums, int x, int y) {
        var temp = nums[x];
        nums[x] = nums[y];
        nums[y] = temp;
    }
}