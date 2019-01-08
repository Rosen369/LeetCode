public class Solution {
    public string GetHint (string secret, string guess) {
        var countS = new int[10];
        var countG = new int[10];
        var bulls = 0;
        var cows = 0;
        for (int i = 0; i < secret.Length; i++) {
            countS[secret[i] - '0']++;
            countG[guess[i] - '0']++;
            if (secret[i] == guess[i]) {
                bulls++;
            }
        }
        var same = 0;
        for (int i = 0; i < 10; i++) {
            same += Math.Min (countS[i], countG[i]);
        }
        cows = same - bulls;
        return string.Format ("{0}A{1}B", bulls, cows);
    }
}