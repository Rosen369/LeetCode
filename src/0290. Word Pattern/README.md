# Word Pattern

Given a `pattern` and a string `str`, find if `str` follows the same pattern.

Here **follow** means a full match, such that there is a bijection between a letter in `pattern` and a **non-empty** word in `str`.

**Example 1:**

```pseudo
Input: pattern = "abba", str = "dog cat cat dog"
Output: true
```

**Example 2:**

```pseudo
Input: pattern = "abba", str = "dog cat cat fish"
Output: false
```

**Example 3:**

```pseudo
Input: pattern = "aaaa", str = "dog cat cat dog"
Output: false
```

**Example 4:**

```pseudo
Input: pattern = "abba", str = "dog dog dog dog"
Output: false
```

**Note:**

You may assume `pattern` contains only lowercase letters, and `str` contains lowercase letters separated by a single space.
