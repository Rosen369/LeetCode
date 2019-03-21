public class Solution {
    public bool IsPowerOfThree (int n) {
        while (n > 1) {
            if (n % 3 != 0) {
                return false;
            }
            n = n / 3;
        }
        return n == 1;
    }
    // 1162261467 is 3^19,  3^20 is bigger than int
    // return ( n>0 &&  1162261467%n==0);
}