public class Solution {
    public int FindComplement (int num) {
        var mask = 1;
        while (mask < num) {
            mask = (mask << 1) | 1;
        }
        return ~num & mask;
    }
}