# Find K Pairs with Smallest Sums

You are given two integer arrays __nums1__ and __nums2__ sorted in ascending order and an integer __k__.

Define a pair __(u,v)__ which consists of one element from the first array and one element from the second array.

Find the k pairs __(u1,v1),(u2,v2) ...(uk,vk)__ with the smallest sums.

__Example 1:__

```
Input: nums1 = [1,7,11], nums2 = [2,4,6], k = 3
Output: [[1,2],[1,4],[1,6]]
Explanation: The first 3 pairs are returned from the sequence:
             [1,2],[1,4],[1,6],[7,2],[7,4],[11,2],[7,6],[11,4],[11,6]
```

__Example 2:__

```
Input: nums1 = [1,1,2], nums2 = [1,2,3], k = 2
Output: [1,1],[1,1]
Explanation: The first 2 pairs are returned from the sequence:
             [1,1],[1,1],[1,2],[2,1],[1,2],[2,2],[1,3],[1,3],[2,3]
```

__Example 3:__

```
Input: nums1 = [1,2], nums2 = [3], k = 3
Output: [1,3],[2,3]
Explanation: All possible pairs are returned from the sequence: [1,3],[2,3]
```
