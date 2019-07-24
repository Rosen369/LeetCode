# Regular Expression Matching

Given an input string (`s`) and a pattern (`p`), implement regular expression matching with support for `'.'` and `'*'`

```pseudo
'.' Matches any single character.
'*' Matches zero or more of the preceding element.
```

The matching should cover the __entire__ input string (not partial).

__Note:__

- `s` could be empty and contains only lowercase letters `a-z`.
- `p` could be empty and contains only lowercase letters `a-z`, and characters like `.` or `*`.

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
p = "a*"
Output: true
Explanation: '*' means zero or more of the precedeng element, 'a'. Therefore, by repeating 'a' once, it becomes "aa".
```

__Example 3:__

```pseudo
Input:
s = "ab"
p = ".*"
Output: true
Explanation: ".*" means "zero or more (*) of any character (.)".
```

__Example 4:__

```pseudo
Input:
s = "aab"
p = "c*a*b"
Output: true
Explanation: c can be repeated 0 times, a can be repeated 1 time. Therefore it matches "aab".
```

__Example 5:__

```pseudo
Input:
s = "mississippi"
p = "mis*is*p*."
Output: false
```