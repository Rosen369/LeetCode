public class Solution {
    public bool IsValidSerialization (string preorder) {
        var arr = preorder.Split (',');
        var len = arr.Length;
        var stack = new Stack<string> ();
        for (int i = 0; i < len; i++) {
            if (arr[i] == "#") {
                while (stack.Count > 1 && stack.Peek () == "#") {
                    stack.Pop ();
                    if (stack.Pop () == "#") {
                        return false;
                    }
                }
                stack.Push ("#");
            } else {
                stack.Push (arr[i]);
            }
        }
        return stack.Count == 1 && stack.Pop () == "#";
    }
}