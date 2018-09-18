public class Solution {
    public int Candy (int[] ratings) {
        var left2right = new int[ratings.Length];
        var right2left = new int[ratings.Length];
        for (int i = 0; i < ratings.Length; i++) {
            if (i == 0) {
                left2right[i] = 1;
                continue;
            }
            if (ratings[i] > ratings[i - 1]) {
                left2right[i] = left2right[i - 1] + 1;
            } else {
                left2right[i] = 1;
            }
        }
        for (int i = ratings.Length - 1; i >= 0; i--) {
            if (i == ratings.Length - 1) {
                right2left[i] = 1;
                continue;
            }
            if (ratings[i] > ratings[i + 1]) {
                right2left[i] = right2left[i + 1] + 1;
            } else {
                right2left[i] = 1;
            }
        }
        var res = 0;
        for (int i = 0; i < ratings.Length; i++) {
            res += Math.Max (left2right[i], right2left[i]);
        }
        return res;
    }
}