public class Solution {
    public int ThirdMax(int[] nums)
    {
        const int maxesCount = 3;
        var maxes = new long[maxesCount];
        var maxSwaps = 0;

        for (var i = 0; i < maxesCount; ++i)
        {
            maxes[i] = long.MinValue;
        }

        for (var i = 0; i < nums.Length; ++i)
        {
            for (var j = 0; j < maxesCount; ++j)
            {
                if(maxes[j] == nums[i])
                {
                    break;
                }

                if (maxes[j] < nums[i])
                {
                    for (var k = maxesCount - 1; k > j; --k)
                    {
                        maxes[k] = maxes[k - 1];
                    }

                    maxes[j] = nums[i];

                    maxSwaps++;

                    break;
                }
            }
        }

        if(maxSwaps > maxesCount - 1)
        {
            return (int)maxes[maxesCount - 1];
        }

        return (int)maxes[0];
    }
}