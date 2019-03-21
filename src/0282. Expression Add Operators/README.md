# Expression Add Operators

Given a string that contains only digits `0-9` and a target value, return all possibilities to add __binary__ operators (not unary) `+`, `-`, or `*` between the digits so they evaluate to the target value.

__Example 1:__

```
Input: num = "123", target = 6
Output: ["1+2+3", "1*2*3"]
```

__Example 2:__

```
Input: num = "232", target = 8
Output: ["2*3+2", "2+3*2"]
```

__Example 3:__

```
Input: num = "105", target = 5
Output: ["1*0+5","10-5"]
```

__Example 4:__

```
Input: num = "00", target = 0
Output: ["0+0", "0-0", "0*0"]
```

__Example 5:__

```
Input: num = "3456237490", target = 9191
Output: []
```