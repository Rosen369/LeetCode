public class Solution {
    public string Multiply (string num1, string num2) {
        if (num1 == "0" || num2 == "0") {
            return "0";
        }
        var bit_buffer = new int[num1.Length + num2.Length];
        for (int i = num1.Length - 1; i >= 0; i--) {
            for (int j = num2.Length - 1; j >= 0; j--) {
                var mul = (num1[i] - '0') * (num2[j] - '0');
                var pos = i + j;
                var next_pos = i + j + 1;
                var sum = mul + bit_buffer[next_pos];

                bit_buffer[pos] += sum / 10;
                bit_buffer[next_pos] = (sum) % 10;
            }
        }
        var sb = new StringBuilder ();
        for (var i = 0; i < bit_buffer.Length; i++) {
            if (!(sb.Length == 0 && bit_buffer[i] == 0)) {
                sb.Append (bit_buffer[i]);
            }
        }
        return sb.ToString ();
    }
}