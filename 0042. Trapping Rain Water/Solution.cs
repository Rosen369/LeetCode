public class Solution {
    public int Trap (int[] height) {
        if (height.Length < 2) {
            return 0;
        }
        var res = 0;
        var left = 0;
        var right = 0;
        while (height[left] == 0) {
            left++;
        }
        right = left + 1;
        while (right < height.Length) {
            if (height[right] >= height[left]) {
                res += SumTrap (left, right, height);
                left = right;
            }
            right++;
        }
        var rest = new List<int> ();
        for (int i = height.Length - 1; i >= left; i--) {
            rest.Add (height[i]);
        }
        res += TrapBack (rest.ToArray ());
        return res;
    }

    public int TrapBack (int[] height) {
        var res = 0;
        var left = 0;
        var right = 0;
        while (height[left] == 0) {
            left++;
        }
        right = left + 1;
        while (right < height.Length) {
            if (height[right] >= height[left]) {
                res += SumTrap (left, right, height);
                left = right;
            }
            right++;
        }
        return res;
    }

    public int SumTrap (int left, int right, int[] height) {
        if (right <= left + 1) {
            return 0;
        }
        var res = 0;
        var min = Math.Min (height[left], height[right]);
        for (; left < right; left++) {
            var sub = min - height[left];
            if (sub > 0) {
                res += sub;
            }
        }
        return res;
    }
}