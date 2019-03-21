# Simplify Path

Given an absolute path for a file (Unix-style), simplify it.

For example,
__path__ = `"/home/"`, => `"/home"`
__path__ = `"/a/./b/../../c/"`, => `"/c"`

Corner Cases:

- Did you consider the case where __path__ = `"/../"`?
    In this case, you should return `"/"`.
- Another corner case is the path might contain multiple slashes `'/'` together, such as `"/home//foo/"`.
    In this case, you should ignore redundant slashes and return `"/home/foo"`.