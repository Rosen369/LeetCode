# Wildcard Matching

Given an input string (`s`) and a pattern (`p`), implement wildcard pattern matching with support for `'?'` and `'*'`.

```pseudo
'?' Matches any single character.
'*' Matches any sequence of characters (including the empty sequence).
```

The matching should cover the __entire__ input string (not partial).

__Note:__

- `s` could be empty and contains only lowercase letters `a-z`.
- `p` could be empty and contains only lowercase letters `a-z`, and characters like `?` or `*`.

__Example 1:__

```pseudo
Input:
s = "aa"
p = "a"
Output: false
Explanation: "a" does not match the entire string "aa".
```

__Example 2:__

```pseudo
Input:
s = "aa"
p = "*"
Output: true
Explanation: '*' matches any sequence.
```

__Example 3:__

```pseudo
Input:
s = "cb"
p = "?a"
Output: false
Explanation: '?' matches 'c', but the second letter is 'a', which does not match 'b'.
```

__Example 4:__

```pseudo
Input:
s = "adceb"
p = "*a*b"
Output: true
Explanation: The first '*' matches the empty sequence, while the second '*' matches the substring "dce".
```

__Example 5:__

```pseudo
Input:
s = "acdcb"
p = "a*c?b"
Output: false
```