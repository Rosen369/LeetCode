# Unique Paths

A robot is located at the top-left corner of a _m_ x _n_ grid (marked 'Start' in the diagram below).

The robot can only move either down or right at any point in time. The robot is trying to reach the bottom-right corner of the grid (marked 'Finish' in the diagram below).

How many possible unique paths are there?

![robot_maze](./robot_maze.png)

Above is a 7 x 3 grid. How many possible unique paths are there?

__Note:__ _m_ and _n_ will be at most 100.

__Example 1:__

```
Input: m = 3, n = 2
Output: 3
Explanation:
From the top-left corner, there are a total of 3 ways to reach the bottom-right corner:
1. Right -> Right -> Down
2. Right -> Down -> Right
3. Down -> Right -> Right
```

__Example 2:__

```
Input: m = 7, n = 3
Output: 28
```