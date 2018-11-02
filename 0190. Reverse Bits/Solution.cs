public class Solution {
    public uint reverseBits (uint n) {
        if (n == 0) return 0;
        uint res = 0;
        for (var i = 0; i < 32; i++) {
            res = res << 1;
            if ((n & 1) == 1) res++;
            n = n >> 1;
        }
        return res;
    }
}