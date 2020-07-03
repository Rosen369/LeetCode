public class Solution {
    public string ReverseStr (string s, int k) {
        var arr = s.ToCharArray ();
        var start = 0;
        while (start < s.Length) {
            var end = Math.Min (start + k - 1, s.Length - 1);
            this.Swap (arr, start, end);
            start += 2 * k;
        }
        return new string (arr);
    }

    private void Swap (char[] arr, int left, int right) {
        while (left < right) {
            var temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            left++;
            right--;
        }
    }
}