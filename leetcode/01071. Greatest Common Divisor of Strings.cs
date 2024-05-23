public class Solution {
    public string GcdOfStrings(string str1, string str2)
    {
        var parent = str1.Length > str2.Length ? str2 : str1;

        var largestPrefix = string.Empty;

        for (var i = parent.Length; i > 0; --i)
        {
            var prefix1 = str1.Substring(0, i);
            var prefix2 = str2.Substring(0, i);

            if(prefix1 == prefix2
               && IsCommonDivisor(str1, prefix1)
               && IsCommonDivisor(str2, prefix1))
            {
                return prefix1;
            }
        }

        return string.Empty;
    }

    private bool IsCommonDivisor(string input, string divisor)
    {
        var divisorLen = divisor.Length;

        if(input.Length % divisorLen != 0)
        {
            return false;
        }

        for (var j = divisorLen; j < input.Length; j+= divisorLen)
        {
            var substring = input.Substring(j, divisorLen);

            if (substring != divisor)
            {
                return false;
            }
        }

        return true;
    }
}