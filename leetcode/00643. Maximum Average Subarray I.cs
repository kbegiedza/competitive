public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        var max = double.MinValue;

        var sum = 0d;

        for (var i = 0; i < k; ++i)
        {
            sum += nums[i];
        }

        if (sum > max)
        {
            max = sum;
        }

        for (var i = k; i < nums.Length; ++i)
        {
            sum -= nums[i - k];
            sum += nums[i];

            if (sum > max)
            {
                max = sum;
            }
        }

        return max / k;
    }
}