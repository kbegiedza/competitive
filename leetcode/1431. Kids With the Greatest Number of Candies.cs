public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var kidsCount = candies.Length;
        var result = new bool[kidsCount];

        var max = -1;

        // find maximum
        for (var i = 0; i < kidsCount; ++i)
        {
            if (candies[i] > max)
            {
                max = candies[i];
            }
        }

        for (var i = 0; i < kidsCount; ++i)
        {
            result[i] = (candies[i] + extraCandies) >= max;
        }

        return result;
    }
}