# Valid Parentheses

Given a string containing just the characters `'('`, `')'`, `'{'`, `'}'`, `'['` and `']'`, determine if the input string is valid.

An input string is valid if:

1. Open brackets must be closed by the same type of brackets.
2. Open brackets must be closed in the correct order.

Note that an empty string is also considered valid.

__Example 1:__

```
Input: "()"
Output: true
```

__Example 2:__

```
Input: "()[]{}"
Output: true
```

__Example 3:__

```
Input: "(]"
Output: false
```

__Example 4:__

```
Input: "([)]"
Output: false
```

__Example 4:__

```
Input: "{[]}"
Output: true
```