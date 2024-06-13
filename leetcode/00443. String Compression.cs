public class Solution {
    public int Compress(char[] chars) {
        char groupChar = chars[0];
        var groupStart = 0;
        var groupEnd = 0;

        var stack = new Stack<char>();
        var groupCount = 0;
        var groupInsertIndex = 0;

        for (var i = 0; i < chars.Length; ++i)
        {
            if (chars[i] == groupChar)
            {
                // is in group
                groupEnd = i;
            }
            else
            {
                //write summary of prev group
                // Console.WriteLine($"group for `{groupChar}` s:{groupStart} e:{groupEnd} c: {groupEnd - groupStart + 1}");

                //assign group char (can be skipped)
                chars[groupInsertIndex] = groupChar;
                ++groupInsertIndex;

                groupCount = groupEnd - groupStart + 1;
                if (groupCount > 1)
                {
                    //encode groupCount
                    while (groupCount > 0)
                    {
                        // Console.WriteLine($" |-> group for `{groupChar}`: {groupCount}");

                        var rest = groupCount % 10;
                        groupCount /= 10;

                        stack.Push((char)(48 + rest));
                    }

                    while(stack.Count > 0)
                    {
                        chars[groupInsertIndex] = stack.Pop();
                        ++groupInsertIndex;
                    }
                }

                //start new group
                groupChar = chars[i];
                groupStart = i;
                groupEnd = i;
            }
        }

        //write summary of prev group
        // Console.WriteLine($"group for `{groupChar}` s:{groupStart} e:{groupEnd} c: {groupEnd - groupStart + 1}");

        //assign group char (can be skipped)
        chars[groupInsertIndex] = groupChar;
        ++groupInsertIndex;

        groupCount = groupEnd - groupStart + 1;
        if (groupCount > 1)
        {
            //encode groupCount
            while (groupCount > 0)
            {
                // Console.WriteLine($" |-> group for `{groupChar}`: {groupCount}");

                var rest = groupCount % 10;
                groupCount /= 10;

                stack.Push((char)(48 + rest));
            }

            while(stack.Count > 0)
            {
                chars[groupInsertIndex] = stack.Pop();
                ++groupInsertIndex;
            }
        }

        return groupInsertIndex;
    }
}