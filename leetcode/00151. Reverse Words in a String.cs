public class Solution {
    public string ReverseWords(string s) {
        var result = new StringBuilder();
        const char space = ' ';

        var wordEndIndex = s.Length;
        var isLastWord = true;
        string substring;

        for (var i = s.Length-1; i >= 0; --i)
        {
            if (s[i] == space)
            {
                var wordLength = wordEndIndex - i - 1;

                if (wordLength > 0)
                {
                    if (isLastWord)
                    {
                        // do not use existing space
                        substring = s.Substring(i + 1, wordLength);
                    }
                    else
                    {
                        // reuse existing space
                        substring =  s.Substring(i, wordLength + 1);
                    }

                    result.Append(substring);
                    isLastWord = false;
                }

                wordEndIndex = i;
            }
        }

        if(wordEndIndex > 0)
        {
            substring = s.Substring(0, wordEndIndex);

            if (!isLastWord)
            {
                result.Append(space);
            }

            result.Append(substring);
        }

        return result.ToString();
    }
}
/*
public class Solution {
    public string ReverseWords(string s) {
        var result = new StringBuilder();
        const char space = ' ';

        var wordEndIndex = s.Length;
        var firstMod = 0;

        for (var i = s.Length-1; i >= 0; --i)
        {
            if (s[i] == space)
            {
                var wordLen = wordEndIndex - i - 1;

                if (wordLen > 0)
                {
                    var substr = s.Substring(i + 1 + firstMod, wordLen - firstMod);

                    result.Append(substr);
                    firstMod = -1;
                }

                wordEndIndex = i;
            }
        }

        if(wordEndIndex > 0)
        {
            var substra = s.Substring(0, wordEndIndex);

            wordEndIndex = 0;

            if (firstMod == -1)
            {
                result.Append(space);
            }

            result.Append(substra);
        }

        return result.ToString();
    }
}
*/