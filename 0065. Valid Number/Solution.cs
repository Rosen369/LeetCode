public class Solution {
    public bool IsNumber (string s) {
        s = s.Trim ();
        var previousIsNumber = false;
        var hasMetE = false;
        var hasMetPoint = false;
        var lastIsNumber = false;
        for (int i = 0; i < s.Length; i++) {
            if (s[i] >= '0' && s[i] <= '9') {
                previousIsNumber = true;
                if (i == s.Length - 1) {
                    lastIsNumber = true;
                }
            } else if (s[i] == '.') {
                if (hasMetE || hasMetPoint) {
                    return false;
                }
                if (i == s.Length - 1) {
                    lastIsNumber = previousIsNumber;
                }
                hasMetPoint = true;
            } else if (s[i] == 'e') {
                if (!previousIsNumber || hasMetE) {
                    return false;
                }
                hasMetE = true;
            } else if (s[i] == '-' || s[i] == '+') {
                if (i != 0 && s[i - 1] != 'e') {
                    return false;
                }
            } else {
                return false;
            }
        }
        return lastIsNumber;
    }
}

// We start with trimming.

// If we see `[0-9]` we reset the number flags.
// We can only see `.` if we didn't see `e` or `.`.
// We can only see `e` if we didn't see `e` but we did see a number. We reset hasMetE flag.
// We can only see `+` and `-` in the beginning and after an `e`
// any other character break the validation.
// At the end it is only valid if there was at least 1 number and if we did see an `e` then a number after it as well.

// So basically the number should match this regular expression:

// [-+]?(([0-9]+(.[0-9]*)?)|.[0-9]+)(e[-+]?[0-9]+)?