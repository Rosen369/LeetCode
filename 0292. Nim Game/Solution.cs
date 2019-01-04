public class Solution {
    public bool CanWinNim (int n) {
        if (n <= 3) {
            return true;
        }
        if (!this.CanWinNim (n - 1)) {
            return true;
        }
        if (!this.CanWinNim (n - 2)) {
            return true;
        }
        if (!this.CanWinNim (n - 3)) {
            return true;
        }
        return false;
    }
}