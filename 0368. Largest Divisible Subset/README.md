# Largest Divisible Subset

Given a set of __distinct__ positive integers, find the largest subset such that every pair (Si, Sj) of elements in this subset satisfies:

Si % Sj = 0 or Sj % Si = 0.

If there are multiple solutions, return any subset is fine.

__Example 1:__

```
Input: [1,2,3]
Output: [1,2] (of course, [1,3] will also be ok)
```

__Example 2:__

```
Input: [1,2,4,8]
Output: [1,2,4,8]
```
