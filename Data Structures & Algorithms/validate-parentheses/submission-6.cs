public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        var openingToClosing = new Dictionary<char, char>{
            {'}', '{'},
            {')', '('},
            {']', '['},
        };
        foreach (char c in s) {
            if (openingToClosing.ContainsKey(c)) {
                if (stack.Count == 0 || stack.Pop() != openingToClosing[c]) {
                    return false;
                }
            }
            else {
                stack.Push(c);
            }
        }
        return stack.Count == 0;
    }
}
