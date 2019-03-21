public class Solution {
    public int[] TwoSum (int[] numbers, int target) {
        var left = 0;
        var right = numbers.Length - 1;
        while (left < right) {
            if (numbers[left] + numbers[right] == target) {
                break;
            }
            if (numbers[left] + numbers[right] > target) {
                right--;
            } else {
                left++;
            }
        }
        return new int[] { left + 1, right + 1 };
    }
}