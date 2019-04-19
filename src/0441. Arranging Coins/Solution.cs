//linear scan solution
//Runtime: 56 ms
//Memory Usage: 13.1 MB
public class Solution {
    public int ArrangeCoins (int n) {
        if (n < 1) {
            return 0;
        }
        var i = 0;
        while (n >= 0) {
            i++;
            n -= i;
        }
        return i - 1;
    }
}

//binary search solution
//Runtime: 40 ms
//Memory Usage: 13.1 MB
public class Solution {
    public int ArrangeCoins (int n) {
        var left = 0;
        var right = n;
        while (left <= right) {
            var mid = (left + right) / 2L;
            var count = (1 + mid) * mid / 2;
            if (count <= n) {
                left = (int) mid + 1;
            } else {
                right = (int) mid - 1;
            }
        }
        return left - 1;
    }
}