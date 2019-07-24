# Ones and Zeroes

In the computer world, use restricted resource you have to generate maximum benefit is what we always want to pursue.

For now, suppose you are a dominator of __m__ `0s` and __n__ `1s` respectively. On the other hand, there is an array with strings consisting of only __0s__ and __1s__.

Now your task is to find the maximum number of strings that you can form with given __m__ `0s` and __n__ `1s`. Each `0` and `1` can be used at most __once__.

__Note:__

1. The given numbers of `0s` and `1s` will both not exceed `100`.
2. The size of given string array won't exceed `600`.

__Example 1:__

```pseudo
Input: Array = {"10", "0001", "111001", "1", "0"}, m = 5, n = 3
Output: 4

Explanation: This are totally 4 strings can be formed by the using of 5 0s and 3 1s, which are "10","0001","1","0".
```

__Example 2:__

```pseudo
Input: Array = {"10", "0", "1"}, m = 1, n = 1
Output: 2

Explanation: You could form "10", but then you'd have nothing left. Better form "0" and "1".
```
