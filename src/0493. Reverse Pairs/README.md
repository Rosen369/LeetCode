# Reverse Pairs

Given an array `nums`, we call `(i, j)` an __important reverse pair__ if `i < j` and `nums[i] > 2*nums[j]`.

You need to return the number of important reverse pairs in the given array.

__Example 1:__

```pseudo
Input: [1,3,2,3,1]
Output: 2
```

__Example 2:__

```pseudo
Input: [2,4,3,5,1]
Output: 3
```

__Note:__

1. The length of the given array will not exceed `50,000`.
2. All the numbers in the input array are in the range of 32-bit integer.
