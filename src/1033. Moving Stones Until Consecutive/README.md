# Moving Stones Until Consecutive

Three stones are on a number line at positions `a`, `b`, and `c`.

Each turn, let's say the stones are currently at positions `x, y, z` with `x < y < z`.  You pick up the stone at either position `x` or position `z`, and move that stone to an integer position `k`, with `x < k < z` and `k != y`.

The game ends when you cannot make any more moves, ie. the stones are in consecutive positions.

When the game ends, what is the minimum and maximum number of moves that you could have made?  Return the answer as an length 2 array: `answer = [minimum_moves, maximum_moves]`

__Example 1:__

```
Input: a = 1, b = 2, c = 5
Output: [1, 2]
Explanation: Move stone from 5 to 4 then to 3, or we can move it directly to 3.
```

__Example 2:__

```
Input: a = 4, b = 3, c = 2
Output: [0, 0]
Explanation: We cannot make any moves.
```

__Note:__

1. 1 <= a <= 100
2. 1 <= b <= 100
3. 1 <= c <= 100
4. a != b, b != c, c != a