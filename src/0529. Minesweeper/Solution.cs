public class Solution {
    public char[][] UpdateBoard (char[][] board, int[] click) {
        this.DFS (board, click[0], click[1]);
        return board;
    }

    private void DFS (char[][] board, int row, int col) {
        if (row < 0 || col < 0 || row >= board.Length || col >= board[0].Length) {
            return;
        }
        if (board[row][col] == 'M') {
            board[row][col] = 'X';
            return;
        }
        if (board[row][col] != 'E') {
            return;
        }
        var directions = new int[][] { new int[] {-1, -1 }, new int[] {-1, 0 }, new int[] {-1, 1 }, new int[] { 0, -1 }, new int[] { 0, 1 }, new int[] { 1, -1 }, new int[] { 1, 0 }, new int[] { 1, 1 } };
        var count = '0';
        for (int i = 0; i < 8; i++) {
            var y = row + directions[i][0];
            var x = col + directions[i][1];
            if (y < 0 || x < 0 || y >= board.Length || x >= board[0].Length) {
                continue;
            }
            if (board[y][x] == 'M') {
                count++;
            }
        }
        if (count == '0') {
            board[row][col] = 'B';
            for (int i = 0; i < 8; i++) {
                var y = row + directions[i][0];
                var x = col + directions[i][1];
                this.DFS (board, y, x);
            }
        } else {
            board[row][col] = count;
        }
    }
}