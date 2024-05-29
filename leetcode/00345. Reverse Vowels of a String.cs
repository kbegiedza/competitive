public class Solution {
    public string ReverseVowels(string s) {
        var left = 0;
        var right = s.Length - 1;

        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        var result = new StringBuilder();
        var q = new Queue<char>();

        for (var i = s.Length - 1; i >=0; --i)
        {
            var item = s[i];

            if (vowels.Contains(item))
            {
                q.Enqueue(s[i]);
            }
        }

        for (var i = 0; i < s.Length; ++i)
        {
            var item = s[i];

            if (vowels.Contains(item))
            {
                result.Append(q.Dequeue());
            }
            else
            {
                result.Append(s[i]);
            }
        }

        return result.ToString();
    }
}