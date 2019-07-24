public class Solution {

    public Solution (double radius, double x_center, double y_center) {
        this._radius = radius;
        this.x_center = x_center;
        this.y_center = y_center;
        this._rand = new Random ();
    }

    private double _radius;

    private double x_center;

    private double y_center;

    private Random _rand;

    public double[] RandPoint () {
        var rand = this._rand.NextDouble ();
        var length = Math.Sqrt (rand) * this._radius;
        var degree = this._rand.NextDouble () * 2 * Math.PI;
        var x = this.x_center + length * Math.Cos (degree);
        var y = this.y_center + length * Math.Sin (degree);
        return new double[] { x, y };
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(radius, x_center, y_center);
 * double[] param_1 = obj.RandPoint();
 */