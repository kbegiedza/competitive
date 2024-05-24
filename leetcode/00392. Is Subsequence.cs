public class Solution {
    public bool IsSubsequence(string s, string t) {
        var i = 0;

        for (var j = 0; j < t.Length && i < s.Length; ++j)
        {
            if (s[i] == t[j])
            {
                ++i;
            }
        }

        return i == s.Length;
    }
}