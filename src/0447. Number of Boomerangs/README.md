# Number of Boomerangs

Given n points in the plane that are all pairwise distinct, a "boomerang" is a tuple of points `(i, j, k)` such that the distance between `i` and `j` equals the distance between `i` and `k` (__the order of the tuple matters__).

Find the number of boomerangs. You may assume that n will be at most __500__ and coordinates of points are all in the range __[-10000, 10000]__ (inclusive).

__Example:__

```
Input:
[[0,0],[1,0],[2,0]]

Output:
2

Explanation:
The two boomerangs are [[1,0],[0,0],[2,0]] and [[1,0],[2,0],[0,0]]
```