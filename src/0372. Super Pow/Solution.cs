public class Solution {
    public int SuperPow (int a, int[] b) {
        a = a % 1337;
        return SuperPow (a, b, b.Length - 1);
    }

    public int SuperPow (int a, int[] b, int index) {
        var right = SuperPow (a, b[index]);
        var left = 1;
        if (index != 0) {
            left = SuperPow (SuperPow (a, b, index - 1), 10);
        }
        return left * right % 1337;
    }

    public int SuperPow (int a, int b) {
        var c = 1;
        for (int i = 0; i < b; i++) {
            c = (c * a) % 1337;
        }
        return c;
    }
}
//https://en.wikipedia.org/wiki/Modular_exponentiation
//Memory-efficient method