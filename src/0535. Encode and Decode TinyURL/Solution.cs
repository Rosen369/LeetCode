public class Codec {

    public Codec () {
        this._longDict = new Dictionary<string, string> ();
        this._shortDict = new Dictionary<string, string> ();
        this._rand = new Random ();
    }

    private IDictionary<string, string> _longDict;

    private IDictionary<string, string> _shortDict;

    private Random _rand;

    private string _code = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

    private string _shortHost = "http://tinyurl.com/";

    // Encodes a URL to a shortened URL
    public string encode (string longUrl) {
        if (this._longDict.ContainsKey (longUrl)) {
            return this._longDict[longUrl];
        }
        var code = this.RandCode ();
        var shortUrl = this._shortDict + code;
        this._shortDict.Add (shortUrl, longUrl);
        this._longDict.Add (longUrl, shortUrl);
        return shortUrl;
    }

    // Decodes a shortened URL to its original URL.
    public string decode (string shortUrl) {
        if (this._shortDict.ContainsKey (shortUrl)) {
            return this._shortDict[shortUrl];
        }
        return string.Empty;
    }

    private string RandCode () {
        var code = string.Empty;
        for (int i = 0; i < 6; i++) {
            code += this.Next ();
        }
        return code;
    }

    private char Next () {
        var n = this._rand.Next (0, 62);
        return this._code[n];
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));