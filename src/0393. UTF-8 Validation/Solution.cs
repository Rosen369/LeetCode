public class Solution {
    public bool ValidUtf8 (int[] data) {
        int rest = 0;
        for (int i = 0; i < data.Length; i++) {
            var b = Convert.ToString (data[i], 2);
            if (b.Length >= 8) {
                b = b.Substring (b.Length - 8);
            } else {
                b = "00000000".Substring (b.Length % 8) + b;
            }
            if (rest == 0) {
                for (int j = 0; j < b.Length; j++) {
                    if (b[j] == '0') {
                        break;
                    }
                    rest++;
                }
                if (rest == 0) {
                    continue;
                }
                if (rest > 4 || rest == 1) {
                    return false;
                }
            } else {
                if (!(b[0] == '1' && b[1] == '0')) {
                    return false;
                }
            }
            rest -= 1;
        }
        return rest == 0;
    }
}