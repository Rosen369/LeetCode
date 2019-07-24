# Create Maximum Number

Given two arrays of length `m` and `n` with digits `0-9` representing two numbers. Create the maximum number of length `k <= m + n` from digits of the two. The relative order of the digits from the same array must be preserved. Return an array of the `k` digits.

__Note:__ You should try to optimize your time and space complexity.

__Example 1:__

```pseudo
Input:
nums1 = [3, 4, 6, 5]
nums2 = [9, 1, 2, 5, 8, 3]
k = 5
Output:
[9, 8, 6, 5, 3]
```

__Example 2:__

```pseudo
Input:
nums1 = [6, 7]
nums2 = [6, 0, 4]
k = 5
Output:
[6, 7, 6, 0, 4]
```

__Example 3:__

```pseudo
Input:
nums1 = [3, 9]
nums2 = [8, 9]
k = 3
Output:
[9, 8, 9]
```