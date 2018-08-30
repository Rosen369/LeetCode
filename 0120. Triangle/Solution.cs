public class Solution {
    public int MinimumTotal (IList<IList<int>> triangle) {
        if (triangle.Count () == 0) {
            return 0;
        }
        for (var i = 1; i < triangle.Count (); i++) {
            for (int j = 0; j < triangle[i].Count (); j++) {
                if (j == 0) {
                    triangle[i][j] += triangle[i - 1][j];
                } else
                if (j == triangle[i].Count () - 1) {
                    triangle[i][j] += triangle[i - 1][j - 1];
                } else {
                    triangle[i][j] += Math.Min (triangle[i - 1][j], triangle[i - 1][j - 1]);
                }
            }
        }
        var min = triangle[triangle.Count () - 1][0];
        for (int i = 0; i < triangle[triangle.Count () - 1].Count (); i++) {
            min = Math.Min (min, triangle[triangle.Count () - 1][i]);
        }
        return min;
    }
}