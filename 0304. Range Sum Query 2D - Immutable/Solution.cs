public class NumMatrix {

    public NumMatrix (int[, ] matrix) {
        var row = matrix.GetLength (0);
        var col = matrix.GetLength (1);
        this._sum = new int[row, col];
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                if (i == 0 && j == 0) {
                    this._sum[i, j] = matrix[i, j];
                } else if (i == 0) {
                    this._sum[i, j] = this._sum[i, j - 1] + matrix[i, j];
                } else if (j == 0) {
                    this._sum[i, j] = this._sum[i - 1, j] + matrix[i, j];
                } else {
                    this._sum[i, j] = this._sum[i, j - 1] + this._sum[i - 1, j] - this._sum[i - 1, j - 1] + matrix[i, j];
                }
            }
        }
    }

    private int[, ] _sum;

    public int SumRegion (int row1, int col1, int row2, int col2) {
        if (row2 < 0 || col2 < 0) {
            return 0;
        }
        var res = this._sum[row2, col2];
        if (row1 == 0 && col1 == 0) {
            return res;
        } else if (row1 == 0) {
            res = res - this._sum[row2, col1 - 1];
        } else if (col1 == 0) {
            res = res - this._sum[row1 - 1, col2];
        } else {
            res = res - this._sum[row1 - 1, col2] - this._sum[row2, col1 - 1] + this._sum[row1 - 1, col1 - 1];
        }
        return res;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */