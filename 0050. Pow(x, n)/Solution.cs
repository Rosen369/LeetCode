public class Solution {
    public double MyPow (double x, int n) {
        if (n < 0) return 1 / x * MyPow (1 / x, -(n + 1));
        if (n == 0) return 1;
        if (n == 2) return x * x;
        if (n % 2 == 0) return MyPow (MyPow (x, n / 2), 2);
        else return x * MyPow (MyPow (x, n / 2), 2);
    }
}