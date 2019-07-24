# Implement Rand10() Using Rand7()

Given a function `rand7` which generates a uniform random integer in the range 1 to 7, write a function rand10 which generates a uniform random integer in the range 1 to 10.

Do NOT use system's `Math.random()`.

__Example 1:__

```pseudo
Input: 1
Output: [7]
```

__Example 2:__

```pseudo
Input: 2
Output: [8,4]
```

__Example 3:__

```pseudo
Input: 3
Output: [8,1,10]
```

__Note:__

`rand7` is predefined.
Each testcase has one argument: `n`, the number of times that `rand10` is called.

__Follow up:__

What is the expected value for the number of calls to `rand7()` function?
Could you minimize the number of calls to `rand7()`?
