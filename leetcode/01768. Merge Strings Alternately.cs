public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var result = new StringBuilder();

        var counter1 = 0;
        var counter2 = 0;

        // cache result to eliminate additional .Length access
        var canUseCounter1 = true;
        var canUseCounter2 = true;

        while(canUseCounter1 || canUseCounter2)
        {
            if(counter1 < word1.Length)
            {
                result.Append(word1[counter1]);

                ++counter1;
            }
            else
            {
                canUseCounter1 = false;
            }

            if(counter2 < word2.Length)
            {
                result.Append(word2[counter2]);
                ++counter2;
            }
            else
            {
                canUseCounter2 = false;
            }
        }

        return result.ToString();
    }
}