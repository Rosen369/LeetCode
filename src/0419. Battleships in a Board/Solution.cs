public class Solution {
    //Runtime: 96 ms
    //Memory Usage: 23.3 MB
    public int CountBattleships (char[][] board) {
        var m = board.Length;
        var n = board[0].Length;
        var count = 0;
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (board[i][j] != 'X') {
                    continue;
                }
                if (j != 0 && board[i][j - 1] == 'X') {
                    continue;
                }
                if (i != 0 && board[i - 1][j] == 'X') {
                    continue;
                }
                count++;
            }
        }
        return count;
    }
}