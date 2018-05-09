public class Solution {
    public int Reverse (int x) {
        var result = 0;
        while (x != 0) {
            var tail = x % 10;
            var newResult = result * 10 + tail;
            if ((newResult - tail) / 10 != result) {
                return 0;
            }
            result = newResult;
            x = x / 10;
        }
        return result;
    }
}