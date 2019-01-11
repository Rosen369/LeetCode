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

    public void Update (int i, int val) {
        var diff = i == 0 ? val - this._sum[i] : val - this._sum[i] + this._sum[i - 1];
        for (int j = i; j < this._sum.Length; j++) {
            this._sum[j] += diff;
        }
    }

    public int SumRange (int i, int j) {
        if (i == 0) {
            return this._sum[j];
        } else {
            return this._sum[j] - this._sum[i - 1];
        }
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * obj.Update(i,val);
 * int param_2 = obj.SumRange(i,j);
 */