# Permutations

The set `[1,2,3,...,n]` contains a total of _n_! unique permutations.

By listing and labeling all of the permutations in order, we get the following sequence for _n_ = 3:

1. `"123"`
2. `"132"`
3. `"213"`
4. `"231"`
5. `"312"`
6. `"321"`

Given _n_ and _k_, return the k^th permutation sequence.

__Note:__

- Given _n_ will be between 1 and 9 inclusive.
- Given _k_ will be between 1 and _n_! inclusive.

__Example 1:__

```
Input: n = 3, k = 3
Output: "213"
```

__Example 2:__

```
Input: n = 4, k = 9
Output: "2314"
```