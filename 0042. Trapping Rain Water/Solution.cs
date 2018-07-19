public class Solution {
    public int Trap (int[] height) {
        var res = 0;
        if (height.Length < 2) {
            return res;
        }
        var peak = 0;
        var index = 0;
        for (int i = 0; i < height.Length; i++) {
            if (height[i] > peak) {
                peak = height[i];
                index = i;
            }
        }
        var leftPart = new List<int> ();
        var rightPart = new List<int> ();
        for (int i = 0; i < height.Length; i++) {
            if (i <= index) {
                leftPart.Add (height[i]);
            }
            if (i >= index) {
                rightPart.Add (height[i]);
            }
        }
        rightPart.Reverse ();
        res += TrapPeak (leftPart.ToArray ());
        res += TrapPeak (rightPart.ToArray ());
        return res;
    }

    public int TrapPeak (int[] height) {
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