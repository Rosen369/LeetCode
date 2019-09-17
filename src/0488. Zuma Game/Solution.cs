public class Solution {
    public int FindMinStep (string board, string hand) {
        return this.DFS (board, hand);
    }

    private int DFS (string board, string hand) {
        board = this.Reduce (board);
        if (string.IsNullOrEmpty (board)) return 0;
        if (string.IsNullOrEmpty (hand)) return -1;
        var res = int.MaxValue;
        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < hand.Length; j++) {
                var nBoard = board.Substring (0, i) + hand[j] + board.Substring (i);
                var nHand = hand.Substring (0, j) + hand.Substring (j + 1);
                var dRes = this.DFS (nBoard, nHand);
                if (dRes != -1) res = Math.Min (dRes, res);
            }
        }
        if (res != int.MaxValue) return res;
        return -1;
    }

    private string Reduce (string board) {
        var count = 1;
        for (int i = 1; i < board.Length; i++) {
            if (board[i] == board[i - 1]) {
                count++;
            } else {
                if (count >= 3) {
                    board = board.Substring (0, i - count + 1) + board.Substring (i + 1);
                    return this.Reduce (board);
                } else {
                    count = 1;
                }
            }
        }
        if (count >= 3) {
            var last = board[board.Length - 1];
            board = board.TrimEnd (last);
        }
        return board;
    }
}