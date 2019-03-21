public class Solution {
    public bool IsPowerOfFour (int num) {
        if (num <= 0) {
            return false;
        }
        if ((num & (num - 1)) != 0) {
            return false;
        }
        if ((num - 1) % 3 != 0) {
            return false;
        }
        return true;
    }
}