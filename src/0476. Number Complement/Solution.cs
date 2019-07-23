/*
Explanation:
We only need flip n bits within the left most to right most
so we create a mash of 1 with n bits
bitwise complement & mask
*/
public class Solution {
    public int FindComplement (int num) {
        var mask = 1;
        while (mask < num) {
            mask = (mask << 1) | 1;
        }
        return ~num & mask;
    }
}