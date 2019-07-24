# Word Pattern

Given a `pattern` and a string `str`, find if `str` follows the same pattern.

Here __follow__ means a full match, such that there is a bijection between a letter in `pattern` and a __non-empty__ word in `str`.

__Example 1:__

```pseudo
Input: pattern = "abba", str = "dog cat cat dog"
Output: true
```

__Example 2:__

```pseudo
Input: pattern = "abba", str = "dog cat cat fish"
Output: false
```

__Example 3:__

```pseudo
Input: pattern = "aaaa", str = "dog cat cat dog"
Output: false
```

__Example 4:__

```pseudo
Input: pattern = "abba", str = "dog dog dog dog"
Output: false
```

__Note:__

You may assume `pattern` contains only lowercase letters, and `str` contains lowercase letters separated by a single space.
