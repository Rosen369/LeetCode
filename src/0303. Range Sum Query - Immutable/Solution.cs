public class NumArray {

    public NumArray (int[] nums) {
        this._sum = new int[nums.Length];
        if (nums.Length > 0) {
            this._sum[0] = nums[0];
            for (int i = 1; i < nums.Length; i++) {
                this._sum[i] = this._sum[i - 1] + nums[i];
            }
        }
    }

    private int[] _sum;

    public int SumRange (int i, int j) {
        if (i > j) {
            return 0;
        }
        if (i == 0) {
            return this._sum[j];
        } else {
            var res = this._sum[j] - this._sum[i - 1];
            return res;
        }
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(i,j);
 */