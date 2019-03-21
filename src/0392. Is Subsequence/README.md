# Is Subsequence

Given a string __s__ and a string __t__, check if __s__ is subsequence of __t__.

You may assume that there is only lower case English letters in both __s__ and __t__. __t__ is potentially a very long (length ~= 500,000) string, and __s__ is a short string (<=100).

A subsequence of a string is a new string which is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (ie, `"ace"` is a subsequence of `"abcde"` while `"aec"` is not).

__Example 1:__

```
s = "abc", t = "ahbgdc"

Return true.
```

__Example 2:__

```
s = "axc", t = "ahbgdc"

Return false.
```

__Follow up:__
If there are lots of incoming S, say S1, S2, ... , Sk where k >= 1B, and you want to check one by one to see if T has its subsequence. In this scenario, how would you change your code?
