public class Solution {
    public string RemoveStars(string s) {
        const char star = '*';
        var stack = new Stack<char>();
        var outputStack = new Stack<char>();

        for (var i = 0; i < s.Length; ++i)
        {
            if(s[i] == star)
            {
                if(stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            else
            {
                stack.Push(s[i]);
            }
        }

        var result = new StringBuilder();

        while(stack.Count > 0)
        {
            outputStack.Push(stack.Pop());
        }

        while(outputStack.Count > 0)
        {
            result.Append(outputStack.Pop());
        }

        return result.ToString();
    }
}