public class Solution
{
    public int HeightChecker(int[] heights)
    {
        var missmatchCounter = 0;

        var sorted = heights.OrderBy(item => item)
                            .ToArray();

        for (var i = 0; i < heights.Length; ++i)
        {
            if (heights[i] != sorted[i])
            {
                ++missmatchCounter;
            }
        }

        return missmatchCounter;
    }
}