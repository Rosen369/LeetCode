public class Solution {
    public string SimplifyPath (string path) {
        var pathArr = path.Split ('/');
        var stack = new Stack<string> ();
        for (int i = 0; i < pathArr.Length; i++) {
            var str = pathArr[i];
            if (string.IsNullOrEmpty (str)) {
                continue;
            } else if (str == ".") {
                continue;
            } else if (str == "..") {
                if (stack.Count != 0) {
                    stack.Pop ();
                }
            } else {
                stack.Push (str);
            }
        }
        var res = string.Join ("/", stack.ToArray ().Reverse());
        return "/" + res;
    }
}