# Substring with Concatenation of All Words

You are given a string, __s__, and a list of __words__, words, that are all of the same length. Find all starting indices of substring(s) in __s__ that is a concatenation of each word in __words__ exactly once and without any intervening characters.

__Example 1:__

```
Input:
  s = "barfoothefoobarman",
  words = ["foo","bar"]
Output: [0,9]
Explanation: Substrings starting at index 0 and 9 are "barfoor" and "foobar" respectively.
The output order does not matter, returning [9,0] is fine too.
```

__Example 2:__

```
Input:
  s = "wordgoodstudentgoodword",
  words = ["word","student"]
Output: []
```