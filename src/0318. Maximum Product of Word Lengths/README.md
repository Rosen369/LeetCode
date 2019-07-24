# Maximum Product of Word Lengths

Given a string array `words`, find the maximum value of `length(word[i]) * length(word[j])` where the two words do not share common letters. You may assume that each word will contain only lower case letters. If no such two words exist, return 0.

__Example 1:__

```pseudo
Input: ["abcw","baz","foo","bar","xtfn","abcdef"]
Output: 16
Explanation: The two words can be "abcw", "xtfn".
```

__Example 2:__

```pseudo
Input: ["a","ab","abc","d","cd","bcd","abcd"]
Output: 4
Explanation: The two words can be "ab", "cd".
```

__Example 2:__

```pseudo
Input: ["a","aa","aaa","aaaa"]
Output: 0
Explanation: No such pair of words.
```
