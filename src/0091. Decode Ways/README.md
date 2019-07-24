# Decode Ways

A message containing letters from `A-Z` is being encoded to numbers using the following mapping:

```pseudo
'A' -> 1
'B' -> 2
...
'Z' -> 26
```

Given a __non-empty__ string containing only digits, determine the total number of ways to decode it.

__Example 1:__

```pseudo
Input: "12"
Output: 2
Explanation: It could be decoded as "AB" (1 2) or "L" (12).
```

__Example 2:__

```pseudo
Input: "226"
Output: 3
Explanation: It could be decoded as "BZ" (2 26), "VF" (22 6), or "BBF" (2 2 6).
```