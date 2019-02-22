public class Solution {
    public string ReverseVowels (string s) {
        var vowels = new HashSet<char> () { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        var arr = s.ToCharArray ();
        var left = 0;
        var right = s.Length - 1;
        while (left < right) {
            while (left < right && !vowels.Contains (s[left])) {
                left++;
            }
            while (left < right && !vowels.Contains (s[right])) {
                right--;
            }
            if (left == right) {
                break;
            }
            Swap (arr, left, right);
            left++;
            right--;
        }
        return new string (arr);
    }

    public void Swap (char[] array, int i, int j) {
        var temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}