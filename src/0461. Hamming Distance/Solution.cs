public class Solution {
    public int HammingDistance (int x, int y) {
        var count = 0;
        var n = x ^ y;
        while (n != 0) {
            count++;
            n &= (n - 1);
        }
        return count;
    }
}