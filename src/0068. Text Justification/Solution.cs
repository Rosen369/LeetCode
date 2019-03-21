public class Solution {
    public IList<string> FullJustify (string[] words, int maxWidth) {
        var res = new List<string> ();
        var groups = GroupWords (words, maxWidth);
        for (int i = 0; i < groups.Count (); i++) {
            var line = string.Empty;
            if (i != groups.Count () - 1) {
                line = FormatLine (groups[i], maxWidth);
            } else {
                line = FormatLastLine (groups[i], maxWidth);
            }
            res.Add (line);
        }
        return res;
    }

    public string FormatLastLine (IList<string> group, int maxWidth) {
        var sb = new StringBuilder ();
        var count = group.Count ();
        for (int i = 0; i < count - 1; i++) {
            sb.Append (group[i]).Append (' ');
        }
        sb.Append (group[count - 1]);
        var spaceLength = maxWidth - sb.Length;
        if (spaceLength != 0) {
            var space = new string (' ', spaceLength);
            sb.Append (space);
        }
        return sb.ToString ();
    }

    public string FormatLine (IList<string> group, int maxWidth) {
        var sb = new StringBuilder ();
        var count = group.Count ();
        var totalLength = group.Sum (e => e.Length);
        if (count == 1) {
            var spaceLength = maxWidth - totalLength;
            var space = string.Empty;
            if (spaceLength != 0) {
                space = new string (' ', spaceLength);
            }
            return group[0] + space;
        }
        var index = 0;
        var spaces = new int[count - 1];
        for (int i = 0; i < maxWidth - totalLength; i++) {
            spaces[index] = spaces[index] + 1;
            index++;
            if (index == spaces.Length) {
                index = 0;
            }
        }
        for (int i = 0; i < count - 1; i++) {
            var space = new string (' ', spaces[i]);
            sb.Append (group[i]).Append (space);
        }
        sb.Append (group[count - 1]);
        return sb.ToString ();
    }

    public IList<IList<string>> GroupWords (string[] words, int maxWidth) {
        var res = new List<IList<string>> ();
        var group = new List<string> ();
        var width = 0;
        for (int i = 0; i < words.Length; i++) {
            if (width + words[i].Length > maxWidth) {
                res.Add (group);
                group = new List<string> ();
                width = 0;
            }
            group.Add (words[i]);
            width = width + words[i].Length + 1;
        }
        res.Add (group);
        return res;
    }
}