/**
 * The Rand7() API is already defined in the parent class SolBase.
 * public int Rand7();
 * @return a random integer in the range 1 to 7
 */
public class Solution : SolBase {
    public int Rand10 () {
        var res = 40;
        while (res >= 40) {
            res = 7 * (this.Rand7 () - 1) + (this.Rand7 () - 1);
        }
        return res % 10 + 1;
    }
}