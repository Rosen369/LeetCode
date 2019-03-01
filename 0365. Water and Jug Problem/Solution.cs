public class Solution {
    public bool CanMeasureWater (int x, int y, int z) {
        if (x + y < z) {
            return false;
        }
        if (x == z || y == z || x + y == z) {
            return true;
        }
        var gcd = Gcd (x, y);
        if (gcd == -1) {
            return false;
        }
        return z % gcd == 0;
    }

    private int Gcd (int a, int b) {
        if (a <= 0 || b <= 0)
            return -1;
        else if (a > b)
            return Gcd (a - b, b);
        else if (a < b)
            return Gcd (a, b - a);
        else
            return a;
    }
}