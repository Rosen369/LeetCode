public class Solution {
    public string ValidIPAddress (string IP) {
        if (this.IsValidIPv4 (IP)) return "IPv4";
        if (this.IsValidIPv6 (IP)) return "IPv6";
        return "Neither";
    }

    private bool IsValidIPv4 (string ip) {
        var tokens = ip.Split ('.');
        if (tokens.Length != 4) return false;
        for (int i = 0; i < 4; i++) {
            if (!this.IsValidIPv4Token (tokens[i])) {
                return false;
            }
        }
        return true;
    }

    private bool IsValidIPv6 (string ip) {
        var tokens = ip.Split (':');
        if (tokens.Length != 8) return false;
        for (int i = 0; i < 8; i++) {
            if (!this.IsValidIPv6Token (tokens[i])) {
                return false;
            }
        }
        return true;
    }

    private bool IsValidIPv4Token (string token) {
        if (token.Length == 0) return false;
        if (token.Length > 3) return false;
        if (token.Length > 1 && token[0] == '0') return false;
        for (int i = 0; i < token.Length; i++) {
            var bit = token[i];
            if (bit < '0') return false;
            if (bit > '9') return false;
        }
        var num = Convert.ToInt32 (token);
        if (num > 255) return false;
        return true;
    }

    private bool IsValidIPv6Token (string token) {
        if (token.Length == 0) return false;
        if (token.Length > 4) return false;
        for (int i = 0; i < token.Length; i++) {
            var bit = token[i];
            if (bit < '0') return false;
            if (bit > '9' && bit < 'A') return false;
            if (bit > 'F' && bit < 'a') return false;
            if (bit > 'f') return false;
        }
        return true;
    }
}