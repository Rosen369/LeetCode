public class Solution {
    public int NextGreaterElement (int n) {
        var arr = n.ToString ().ToCharArray ();
        var d = -1;
        for (int i = arr.Length - 1; i > 0; i--) {
            if (arr[i - 1] < arr[i]) {
                d = i - 1;
                break;
            }
        }
        if (d == -1) {
            return -1;
        }

        var m = d + 1;
        for (int i = arr.Length - 1; i > d; i--) {
            if (arr[i] > arr[d] && arr[i] < arr[m]) {
                m = i;
            }
        }

        var temp = arr[d];
        arr[d] = arr[m];
        arr[m] = temp;

        Array.Sort (arr, d + 1, arr.Length - d - 1);

        var ns = new string (arr);
        var nl = Convert.ToInt64 (ns);
        if (nl > int.MaxValue) {
            return -1;
        }

        return (int) nl;
    }
}