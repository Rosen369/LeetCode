public class Solution {
    public string AddBinary (string a, string b) {
        var longger = a;
        var shorter = b;
        if (a.Length < b.Length) {
            longger = b;
            shorter = a;
        }
        var charList = new char[longger.Length];
        var flow = false;
        for (int i = longger.Length - 1; i >= 0; i--) {
            var longBit = longger[i];
            var shortBit = '0';
            if (i - (longger.Length - shorter.Length) >= 0) {
                shortBit = shorter[i - (longger.Length - shorter.Length)];
            }
            if (longBit == '0' && shortBit == '0' && flow == false) {
                charList[i] = '0';
                flow = false;
            } else if (longBit == '0' && shortBit == '0' && flow == true) {
                charList[i] = '1';
                flow = false;
            } else if (longBit == '1' && shortBit == '0' && flow == false) {
                charList[i] = '1';
                flow = false;
            } else if (longBit == '0' && shortBit == '1' && flow == false) {
                charList[i] = '1';
                flow = false;
            } else if (longBit == '1' && shortBit == '0' && flow == true) {
                charList[i] = '0';
                flow = true;
            } else if (longBit == '0' && shortBit == '1' && flow == true) {
                charList[i] = '0';
                flow = true;
            } else if (longBit == '1' && shortBit == '1' && flow == false) {
                charList[i] = '0';
                flow = true;
            } else if (longBit == '1' && shortBit == '1' && flow == true) {
                charList[i] = '1';
                flow = true;
            }
        }
        var res = new string (charList);
        if (flow == true) {
            res = "1" + res;
        }
        return res;
    }
}